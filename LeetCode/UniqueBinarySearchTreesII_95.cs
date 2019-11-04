using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class UniqueBinarySearchTreesII_95
	{

		//给定一个整数 n，生成所有由 1 ... n 为节点所组成的二叉搜索树。
		public IList<TreeNode> GenerateTrees(int n)
		{
			if (n == 0) return new List<TreeNode>();
			return Gen(1, n);
		}

		public List<TreeNode> Gen(int start,int end)
		{
			List<TreeNode> all_trees = new List<TreeNode>();
			if (start > end)
			{
				all_trees.Add(null);
				return all_trees;
			}

			for(int i = start; i <= end; i++)
			{
				List<TreeNode> left = Gen(start, i - 1);
				List<TreeNode> right = Gen(i + 1, end);

				foreach(TreeNode l in left)
				{
					foreach(TreeNode r in right)
					{
						TreeNode cur = new TreeNode(i);
						cur.left = l;
						cur.right = r;
						all_trees.Add(cur);
					}
				}
			}
			return all_trees;
		}
	}
}
