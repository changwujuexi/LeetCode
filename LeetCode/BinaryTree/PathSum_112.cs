using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTree
{
	class PathSum_112
	{
		//给定一个二叉树和一个目标和，判断该树中是否存在根节点到叶子节点的路径，这条路径上所有节点值相加等于目标和。
		public bool HasPathSum(TreeNode root, int sum)
		{
			if (root == null) return false;
			return IsSum(sum, root);
		}

		public bool IsSum(int sum, TreeNode node)
		{
			if (node == null) return false;
			if (node.left == null && node.right == null) return node.val == sum ? true : false;

			return IsSum(sum - node.val, node.left) || IsSum(sum - node.val, node.right);
		}
	}
}
