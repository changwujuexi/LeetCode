using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
	class IntersectionOfTwoArrays_349
	{
		//给定两个数组，编写一个函数来计算它们的交集。
		public int[] Intersection(int[] nums1, int[] nums2)
		{
			return nums1.Intersect(nums2).ToArray();

		}
	}
}
