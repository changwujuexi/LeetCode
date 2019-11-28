using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.PrefixTree
{
	class ReplaceWords_648
	{
		public string ReplaceWords(IList<string> dict, string sentence)
		{
			Trie trie = new Trie();
			foreach (string s in dict) trie.Insert(s);
			string[] ss = sentence.Split(' ');
			StringBuilder sb = new StringBuilder();
			foreach(string s in ss)
			{
				string repl = trie.Search(s);
				if (repl == "") sb.Append(s);
				else sb.Append(repl);
				sb.Append(" ");
			}
			return sb.ToString().Trim();
		}

		public class TrieNode
		{
			public TrieNode[] links;
			public bool IsEnd;
			public TrieNode()
			{
				links = new TrieNode[26];
			}

			public bool ContainsKey(char ch)
			{
				return links[ch - 'a'] != null;
			}

			public TrieNode Get(char ch)
			{
				return links[ch - 'a'];
			}

			public TrieNode Put(char ch, TrieNode node)
			{
				return links[ch - 'a'] = node;
			}
		}

		public class Trie
		{
			TrieNode root;

			public Trie() { root = new TrieNode(); }

			public void Insert(string word)
			{
				TrieNode node = root;
				int len = word.Length;
				for(int i = 0; i < len; i++)
				{
					char ch = word[i];
					if (!node.ContainsKey(ch)) node.Put(ch, new TrieNode());
					node = node.Get(ch);
				}
				node.IsEnd = true;
			}

			public string Search(string word)
			{
				TrieNode node = root;
				int len = word.Length;
				StringBuilder sb = new StringBuilder();
				for(int i = 0; i < len; i++)
				{
					char ch = word[i];
					if (!node.ContainsKey(ch)) return "";
					sb.Append(ch);
					node = node.Get(ch);
					if (node.IsEnd) return sb.ToString();
				}
				return "";
			}

		}
	}
}
