using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.PrefixTree
{
	

	class MapSum
	{
		public class Node
		{
			public int val;
			public int sum;
			public Hashtable next;
			public Node()
			{
				next = new Hashtable();
			}
		}

		public int Add(Node node, string word, int index, int val)
		{
			if (index == word.Length)
			{
				int ret = val - node.val;
				node.sum += ret;
				node.val = val;
				return ret;
			}
			char c = word[index];
			if (!node.next.ContainsKey(c)) node.next.Add(c, new Node());
			int _ret = Add((Node)node.next[c], word, index + 1, val);
			node.sum += _ret;
			return _ret;

		}

		private Node root;

		/** Initialize your data structure here. */
		public MapSum()
		{
			root = new Node();
		}

		public void Insert(string key, int val)
		{
			Add(root, key, 0, val);
		}

		public int Sum(string prefix)
		{
			Node node = root;
			for(int i = 0; i < prefix.Length; i++)
			{
				char c = prefix[i];
				if (!node.next.Contains(c)) return 0;
				node = (Node)node.next[c];
			}
			return node.sum;
		}
	}
}
