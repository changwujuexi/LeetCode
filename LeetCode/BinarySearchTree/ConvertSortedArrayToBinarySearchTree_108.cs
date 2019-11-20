﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearchTree
{
	class ConvertSortedArrayToBinarySearchTree_108
	{
		//将一个按照升序排列的有序数组，转换为一棵高度平衡二叉搜索树。
		//本题中，一个高度平衡二叉树是指一个二叉树每个节点 的左右两个子树的高度差的绝对值不超过 1。

		public TreeNode SortedArrayToBST(int[] nums)
		{
			return nums == null ? null : BuildBinarySearchTree(nums, 0, nums.Length - 1);
		}

		public TreeNode BuildBinarySearchTree(int[] nums, int left, int right)
		{
			if (left > right) return null;
			int mid = left + (right - left) / 2;
			TreeNode cur = new TreeNode(nums[mid]);
			cur.left = BuildBinarySearchTree(nums, left, mid - 1);
			cur.right = BuildBinarySearchTree(nums, mid + 1, right);
			return cur;
		}

	}
}
