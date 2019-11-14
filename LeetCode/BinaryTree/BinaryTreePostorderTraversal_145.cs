﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTree
{
	class BinaryTreePostorderTraversal_145
	{
		//给定一个二叉树，返回它的 后序 遍历。
		public static IList<int> PostorderTraversal(TreeNode root)
		{
			var list = new List<int>();
			var stack = new Stack<TreeNode>();
			if (root == null) return list;
			stack.Push(root);

			while (stack.Count != 0)
			{
				var right = root.right;
				var left = root.left;
				if (right != null)
				{
					stack.Push(right);
					root.right = null;
				}
				if (left != null)
				{
					stack.Push(left);
					root.left = null;
				}

				if (right == null && left == null)
				{
					var cur = stack.Pop();
					list.Add(cur.val);
				}
				if (stack.Count != 0) root = stack.Peek();

			}
			return list;



		}

		static void Main(string[] args)
		{
			PostorderTraversal()
		}
	}
}
