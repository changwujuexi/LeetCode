using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class MaximumDepthOfBinaryTree_104
	{
		//		给定一个二叉树，找出其最大深度。

		//二叉树的深度为根节点到最远叶子节点的最长路径上的节点数。

		//说明: 叶子节点是指没有子节点的节点。


		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			TreeNode(int x) { val = x; }
		}


		public int MaxDepth(TreeNode root)
		{
			if (root == null) return 0;
			else
			{
				int left = MaxDepth(root.left);
				int right = MaxDepth(root.right);
				return Math.Max(left, right) + 1;
			}
		}
	}
}
