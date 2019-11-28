using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.PrefixTree
{
	class TrieNode
	{
		public TrieNode[] children;
		public bool is_end;
		public TrieNode()
		{
			children = new TrieNode[26];
			is_end = false;
		}
	}

	public class Trie
	{
		//实现一个 Trie (前缀树)，包含 insert, search, 和 startsWith 这三个操作。

		TrieNode root;
		/** Initialize your data structure here. */
		public Trie()
		{
			root = new TrieNode();
		}

		/** Inserts a word into the trie. */
		public void Insert(string word)
		{
			TrieNode ptr = root;
			for(int i = 0; i < word.Length; i++)
			{
				char c = word[i];
				if (ptr.children[c - 'a'] == null) ptr.children[c - 'a'] = new TrieNode();
				ptr = ptr.children[c - 'a'];
			}
			ptr.is_end = true;
		}

		/** Returns if the word is in the trie. */
		public bool Search(string word)
		{
			TrieNode ptr = root;
			for(int i = 0; i < word.Length; i++)
			{
				char c = word[i];
				if (ptr.children[c - 'a'] == null) return false;
				ptr = ptr.children[c - 'a'];
			}
			return ptr.is_end;
		}

		/** Returns if there is any word in the trie that starts with the given prefix. */
		public bool StartsWith(string prefix)
		{
			TrieNode ptr = root;
			for (int i = 0; i < prefix.Length; i++)
			{
				char c = prefix[i];
				if (ptr.children[c - 'a'] == null) return false;
				ptr = ptr.children[c - 'a'];
			}
			return true;
		}
	}
}
