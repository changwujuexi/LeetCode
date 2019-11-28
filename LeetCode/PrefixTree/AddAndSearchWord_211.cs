using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.PrefixTree
{
	class WordDictionary
	{
		//设计一个支持以下两种操作的数据结构：

		//void addWord(word)
		//bool search(word)
		//search(word)可以搜索文字或正则表达式字符串，字符串只包含字母.或 a-z 。 . 可以表示任何一个字母。

		private Trie trie;

		/** Initialize your data structure here. */
		public WordDictionary()
		{
			trie = new Trie();
		}

		/** Adds a word into the data structure. */
		public void AddWord(string word)
		{
			trie.Insert(word);
		}

		/** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
		public bool Search(string word)
		{
			return trie.Seach(word);
		}

		public class TrieNode
		{
			public TrieNode[] children;
			public bool IsEnd;
			public TrieNode()
			{
				children = new TrieNode[26];
			}

			public bool Contains(char key)
			{
				return children[key - 'a'] != null;
			}

		}

		public class Trie
		{
			TrieNode root;
			public Trie()
			{
				root = new TrieNode();
			}

			public void Insert(string word)
			{
				TrieNode cur = root;
				for(int i = 0; i < word.Length; i++)
				{
					char ch = word[i];
					if (cur.children[ch - 'a'] == null) cur.children[ch - 'a'] = new TrieNode();
					cur = cur.children[ch - 'a'];
				}
				cur.IsEnd = true;
			}


			public bool Seach(string word)
			{
				return Dfs(root, word, 0);
			}

			public bool Dfs(TrieNode root,string word,int index)
			{
				if (index >= word.Length) return root.IsEnd;
				char cur = word[index];
				if (cur != '.')
				{
					if (root.Contains(cur)) return Dfs(root.children[cur - 'a'], word, index + 1);
					return false;
				}
				foreach(TrieNode node in root.children)
				{
					if (node != null && Dfs(node, word, index + 1)) return true;
				}
				return false;
			}
		}

		//static void Main(string[] args)
		//{
		//	WordDictionary da = new WordDictionary();
		//	da.AddWord("bad");
		//	da.AddWord("dad");
		//	da.AddWord("mad");
		//	da.Search("pad");
		//	da.Search("bad");
		//	da.Search(".ad");
		//	da.Search("b..");
		//}
	}
}
