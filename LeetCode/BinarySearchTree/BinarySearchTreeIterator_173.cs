using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearchTree
{
	class BSTIterator
	{
		//实现一个二叉搜索树迭代器。你将使用二叉搜索树的根节点初始化迭代器。

		//调用 next() 将返回二叉搜索树中的下一个最小的数。

		private Stack<TreeNode> stack = new Stack<TreeNode>();

		public BSTIterator(TreeNode root)
		{
			while (root != null)
			{
				stack.Push(root);
				root = root.left;
			}
		}

		/** @return the next smallest number */
		public int Next()
		{
			TreeNode cur = stack.Pop();
			int val = cur.val;
			cur = cur.right;
			while (cur != null)
			{
				stack.Push(cur);
				cur = cur.left;

			}
			return val;
		}

		/** @return whether we have a next smallest number */
		public bool HasNext()
		{
			return !(stack.Count == 0);
		}

	}
}
