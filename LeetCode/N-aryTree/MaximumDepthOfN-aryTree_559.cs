using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.N_aryTree
{
	class MaximumDepthOfN_aryTree_559
	{
		//给定一个 N 叉树，找到其最大深度。
		//最大深度是指从根节点到最远叶子节点的最长路径上的节点总数。

		public int MaxDepth(Node root)
		{
			if (root == null) return 0;
			int depth = 0;
			for (int i = 0; i < root.children.Count; i++) depth = Math.Max(depth, MaxDepth(root.children[i]));
			return depth + 1;
		}
	}
}
