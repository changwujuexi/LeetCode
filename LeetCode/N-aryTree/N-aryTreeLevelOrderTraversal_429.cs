using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.N_aryTree
{
	class N_aryTreeLevelOrderTraversal_429
	{
		//给定一个 N 叉树，返回其节点值的层序遍历。 (即从左到右，逐层遍历)。
		public IList<IList<int>> LevelOrder(Node root)
		{
			var list = new List<IList<int>>();
			if (root == null) return list;

			var stack1 = new Stack<Node>();
			var stack2 = new Stack<Node>();

			stack1.Push(root);
			while (true)
			{
				if (stack1.Count != 0)
				{
					List<int> mlist = new List<int>();
					while (stack1.Count != 0)
					{
						Node cur = stack1.Pop();
						mlist.Add(cur.val);
						for (int i = cur.children.Count - 1; i >= 0; i--) stack2.Push(cur.children[i]);
					}
					mlist.Reverse();
					list.Add(mlist);
				}
				else if (stack2.Count != 0)
				{
					List<int> mlist = new List<int>();
					while (stack2.Count != 0)
					{
						Node cur = stack2.Pop();
						mlist.Add(cur.val);
						for (int i = 0; i < cur.children.Count; i++) stack1.Push(cur.children[i]);
					}
					list.Add(mlist);
				}
				else return list;
			}
		}
	}
}
