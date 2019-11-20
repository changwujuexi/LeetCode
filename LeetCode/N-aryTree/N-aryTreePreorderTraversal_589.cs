using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.N_aryTree
{
	public class Node
	{
		public int val;
		public IList<Node> children;

		public Node() { }

		public Node(int _val)
		{
			val = _val;
		}

		public Node(int _val, IList<Node> _children)
		{
			val = _val;
			children = _children;
		}
	}

	class N_aryTreePreorderTraversal_589
	{
		//给定一个 N 叉树，返回其节点值的前序遍历。
		public IList<int> Preorder(Node root)
		{
			var list = new List<int>();
			if (root == null) return list;
			var stack = new Stack<Node>();
			stack.Push(root);
			while (stack.Count != 0)
			{
				var cur = stack.Pop();
				list.Add(cur.val);
				for(int i = cur.children.Count - 1; i >= 0; i--)
				{
					stack.Push(cur.children[i]);
				}

			}
			return list;
		}
	}
}
