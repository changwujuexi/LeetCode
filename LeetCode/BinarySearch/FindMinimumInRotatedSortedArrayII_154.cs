﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
	//假设按照升序排序的数组在预先未知的某个点上进行了旋转。
	//( 例如，数组[0, 1, 2, 4, 5, 6, 7] 可能变为[4, 5, 6, 7, 0, 1, 2])。
	//请找出其中最小的元素。
	//注意数组中可能存在重复的元素。
	class FindMinimumInRotatedSortedArrayII_154
	{
		public int FindMin(int[] nums)
		{
			int left = 0, right = nums.Length - 1;
			int mid = left + (right - left) / 2;
			while (right > left)
			{
				if (nums[mid] > nums[right]) left = mid + 1;
				else if (nums[mid] < nums[right]) right = mid;
				else right = right - 1;
				mid = left + (right - left) / 2;
			}
			return nums[left];
		}
	}
}
