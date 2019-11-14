using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTree
{
	class BinaryTreePreorderTraversal_144
	{
		//给定一个二叉树，返回它的 前序 遍历。
		public IList<int> PreorderTraversal(TreeNode root)
		{
			var list = new List<int>();
			if (root == null) return list;
			var stack = new Stack<TreeNode>();

			stack.Push(root);
			while (stack.Count != 0)
			{
				var node = stack.Pop();
				list.Add(node.val);
				var left = node.left;
				var right = node.right;
				if (right != null) stack.Push(right);
				if (left != null) stack.Push(left);
			}
			return list;
		}
	}
}
