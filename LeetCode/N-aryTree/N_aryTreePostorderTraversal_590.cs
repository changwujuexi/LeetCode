using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.N_aryTree
{
	class N_aryTreePostorderTraversal_590
	{
		//给定一个 N 叉树，返回其节点值的后序遍历。

		public IList<int> Postorder(Node root)
		{
			var list = new List<int>();
			if (root == null) return list;
			var stack = new Stack<Node>();

			stack.Push(root);
			while (stack.Count != 0)
			{
				var cur = stack.Pop();
				list.Add(cur.val);

				for(int i = 0; i <= cur.children.Count - 1; i++)
				{
					stack.Push(cur.children[i]);
				}
			}
			list.Reverse();
			return list;
		}


	}
}
