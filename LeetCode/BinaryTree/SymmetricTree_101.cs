using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTree
{
	class SymmetricTree_101
	{
		//给定一个二叉树，检查它是否是镜像对称的。

		//例如，二叉树[1, 2, 2, 3, 4, 4, 3] 是对称的。

		//    1
		//   / \
		//  2   2
		// / \ / \
		//3  4 4  3

		//递归
		//public bool IsSymmetric(TreeNode root)
		//{
		//	if (root == null) return true;

		//	return IsMirror(root.left, root.right);
		//}

		//public bool IsMirror(TreeNode leftNode,TreeNode rightNode)
		//{
		//	if (leftNode == null && rightNode == null) return true;
		//	if (leftNode == null || rightNode == null) return false;

		//	return IsMirror(leftNode.left, rightNode.right) && IsMirror(leftNode.right, rightNode.left) && leftNode.val == rightNode.val;
		//}

		//迭代
		public bool IsSymmetric(TreeNode root)
		{
			if (root == null) return true;
			TreeNode left, right;

			var stack = new Stack<TreeNode>();
			stack.Push(root);
			stack.Push(root);

			while (stack.Count != 0)
			{

				left = stack.Pop();
				right = stack.Pop();
				if (left == null && right == null) continue;
				if (left == null || right == null) return false;
				if (left.val != right.val) return false;

				stack.Push(left.left);
				stack.Push(right.right);
				stack.Push(left.right);
				stack.Push(right.left);
			}
			return true;
		}

	}
}
