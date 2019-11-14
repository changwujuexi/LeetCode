using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
	class MedianOfTwoSortedArrays_4
	{
		//给定两个大小为 m 和 n 的有序数组 nums1 和 nums2。
		//请你找出这两个有序数组的中位数，并且要求算法的时间复杂度为 O(log(m + n))。
		//你可以假设 nums1和 nums2不会同时为空。
		public double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{
			int m = nums1.Length;
			int n = nums2.Length;
			int left = (m + n + 1) / 2;
			int right = (m + n + 2) / 2;
			return (GetKth(nums1, 0, m - 1, nums2, 0, n - 1, left) + GetKth(nums1, 0, m - 1, nums2, 0, n - 1, right)) * 0.5;
		}

		public int GetKth(int[]nums1,int start1,int end1,int[]nums2,int start2,int end2,int k)
		{
			int len1 = end1 - start1 + 1;
			int len2 = end2 - start2 + 1;

			if (len1 > len2) return GetKth(nums2, start2, end2, nums1, start1, end1, k);
			if (len1 == 0) return nums2[start2 + k - 1];

			if (k == 1) return Math.Min(nums1[start1], nums2[start2]);

			int i = start1 + Math.Min(len1, k / 2) - 1;
			int j = start2 + Math.Min(len2, k / 2) - 1;

			if (nums1[i] > nums2[j]) return GetKth(nums1, start1, end1, nums2, j + 1, end2, k - (j - start2 + 1));
			else return GetKth(nums1, i + 1, end1, nums2, start2, end2, k - (i - start1 + 1));

		}

		//static void Main(string[] args)
		//{
		//	FindMedianSortedArrays(new int[] {}, new int[] {2,3});
		//}
	}
}
