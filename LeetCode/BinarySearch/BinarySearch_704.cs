using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
	class BinarySearch_704
	{
		//给定一个 n个元素有序的（升序）整型数组 nums 和一个目标值 target  ，写一个函数搜索 nums中的 target，如果目标值存在返回下标，否则返回 -1。

		public int Search(int[] nums, int target)
		{
			return BinarySearch(nums, 0, nums.Length, target);
		}

		public int BinarySearch(int[] nums,int start,int end,int target)
		{
			if (start == end) return -1;
			int mid = (start + end) / 2;
			if (nums[mid] == target) return mid;
			return nums[mid] > target ? BinarySearch(nums, start, mid, target) : BinarySearch(nums, mid + 1, end, target);

		}

		//static void Main(string[] args)
		//{
		//	BinarySearch_704 sd = new BinarySearch_704();
		//	int[] ds = new int[] { -1, 0, 3, 5, 9, 12 };
		//	sd.Search(ds,2);
		//}

	}
}
