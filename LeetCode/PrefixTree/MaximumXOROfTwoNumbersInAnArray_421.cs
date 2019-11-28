using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.PrefixTree
{
	class MaximumXOROfTwoNumbersInAnArray_421
	{
		class TrieNode
		{
			public TrieNode[] children;

			public TrieNode()
			{
				children = new TrieNode[2];
			}
		}

		class Trie
		{
			TrieNode root;
			public Trie()
			{
				root = new TrieNode();
			}

			public void Insert(int num)
			{
				TrieNode cur = root;
				for(int i = 31; i >= 0; i--)
				{
					int v = num >> i & 1;
					if (cur.children[v] == null) cur.children[v] = new TrieNode();
					cur = cur.children[v];
				}
			}

			public int GetXorNum(int num)
			{
				TrieNode cur = root;
				int result = 0;
				for(int i = 31; i >= 0; i--)
				{
					int v = num >> i & 1;
					if (cur.children[v ^ 1] != null)
					{
						result += 1 << i;
						cur = cur.children[v ^ 1];
						continue;
					}
					else if (cur.children[v] == null) return result;
					cur = cur.children[v];
					
				}
				return result;
			}

			public int GetMaxNum(int[] nums)
			{
				int result = 0;
				foreach (int num in nums)
				{
					int temp = GetXorNum(num);
					result = result > temp ? result : temp;
				}
				return result;
			}
		}

		public int FindMaximumXOR(int[] nums)
		{
			Trie trie = new Trie();
			foreach (int num in nums) trie.Insert(num);

			return trie.GetMaxNum(nums);


		}

		//static void Main(string[] args)
		//{
		//	MaximumXOROfTwoNumbersInAnArray_421 da = new MaximumXOROfTwoNumbersInAnArray_421();
		//	da.FindMaximumXOR(new int[] { 3, 10, 5, 25, 2, 8 });
		//}
	}
}
