using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.PrefixTree
{
	class WordSearchII_212
	{
		public class TrieNode
		{
			public TrieNode[] children;
			public bool IsEnd;
			public string val;
			public TrieNode()
			{
				children = new TrieNode[26];
				IsEnd = false;
			}
		}

		public class Trie
		{
			public TrieNode root;

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
				cur.val = word;
			}

		}

		public IList<string> FindWords(char[][] board, string[] words)
		{
			Trie trie = new Trie();
			TrieNode root = trie.root;
			foreach (string s in words) trie.Insert(s);

			var result = new HashSet<string>();
			int m = board.Length;
			int n = board[0].Length;
			bool[,] visited = new bool[m, n];

			for(int i = 0; i < m; i++)
			{
				for(int j = 0; j < n; j++)
				{
					Find(board, visited, i, j, m, n, result, root);
				}
			}

			return new List<string>(result);

		}

		public void Find(char[][] board, bool[,] visited, int i, int j, int m, int n, HashSet<string> result, TrieNode cur)
		{
			if (i < 0 || i >= m || j < 0 || j >= n || visited[i, j]) return;
			cur = cur.children[board[i][j] - 'a'];
			visited[i, j] = true;
			if (cur == null)
			{
				visited[i, j] = false;
				return;
			}

			if (cur.IsEnd)
			{
				result.Add(cur.val);
			}

			Find(board, visited, i + 1, j, m, n, result, cur);
			Find(board, visited, i - 1, j, m, n, result, cur);
			Find(board, visited, i, j + 1, m, n, result, cur);
			Find(board, visited, i, j - 1, m, n, result, cur);

			visited[i, j] = false;
		}

	}
}
