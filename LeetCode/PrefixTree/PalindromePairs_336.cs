using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetCode.PrefixTree
{
	class PalindromePairs_336
	{
		//给定一组唯一的单词， 找出所有不同 的索引对(i, j)，使得列表中的两个单词， words[i] + words[j] ，可拼接成回文串。

		//示例 1:

		//输入: ["abcd","dcba","lls","s","sssll"]
		//		输出: [[0,1],[1,0],[3,2],[2,4]] 
		//解释: 可拼接成的回文串为["dcbaabcd", "abcddcba", "slls", "llssssll"]
		public IList<IList<int>> PalindromePairs(string[] words)
		{
			if (words.Length == 0) return null;
			var list = new List<IList<int>>();
			Trie trie = new Trie();

			for (int i = 0; i < words.Length; i++)
			{
				trie.Insert(words[i], i);
			}

			for(int i = 0; i < words.Length; i++)
			{
				var listRec = trie.SearchPalindromPair(words[i], i);
				foreach (List<int> l in listRec) list.Add(l);
			}

			return list;

		}

		public class TrieNode
		{
			public TrieNode[] children;
			public Hashtable words;
			public bool isEnd;
			
			public TrieNode()
			{
				children = new TrieNode[26];
				words = new Hashtable();
			}
		}

		public class Trie
		{
			public TrieNode root;

			public Trie()
			{
				root = new TrieNode();
			}

			public void Insert(string word, int index)
			{
				TrieNode cur = root;
				for(int i = 0; i < word.Length; i++)
				{
					if (cur.children[word[i] - 'a'] == null) cur.children[word[i] - 'a'] = new TrieNode();
					cur.words.Add(word.Substring(i), index);
					cur = cur.children[word[i] - 'a'];
				}
				cur.isEnd = true;
			}

			public IList<IList<int>> SearchPalindromPair(string word, int index)
			{
				TrieNode cur = root;
				
				//把word反转为curWord来查询
				char[] a = word.ToCharArray();
				Array.Reverse(a);
				string curWord = new string(a);

				var list = new List<IList<int>>();

				for (int i = 0; i < word.Length; i++)
				{
					var child = cur.children[curWord[i] - 'a'];

					if (child != null)
					{
						if (child.isEnd)
						{
							//如果查询的单词还没用完，检查剩下的部分是不是回文。
							if (i < word.Length - 1)
							{
								if (IsPalindromPar(curWord.Substring(i + 1))) list.Add(new List<int> { (int)root.words[curWord.Substring(0, i + 1)], index });
							}
							else if ((int)root.words[curWord] != index) list.Add(new List<int> { (int)root.words[curWord], index });
						}
					}
					else return list;

					cur = child;
				}

				//如果查询的单词用完了，此时子树还有没结束的单词，分别检查他们剩下的部分是不是回文。
				if (cur.words.Count != 0) 
				{
					foreach(string w in cur.words.Keys)
					{
						if (IsPalindromPar(w))
						{
							list.Add(new List<int> { (int)cur.words[w], index });
							if (word == "") list.Add(new List<int> { index, (int)cur.words[w] });
						}
					}
				}

				return list;
			}

			public bool IsPalindromPar(string str)
			{
				int i = 0, j = str.Length - 1;
				while (i < j)
				{
					if (str[i] != str[j]) return false;
					i++; j--;
				}
				return true;
			}
		}

		//static void Main(string[] args)
		//{
		//	PalindromePairs_336 ds = new PalindromePairs_336();
		//	string[] words = new string[] { "a", "abc", "aba", ""};
		//	ds.PalindromePairs(words);
		//}
	}
}
