using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
	class FindK_thSmallestPairDistance_719
	{
		//给定一个整数数组，返回所有数对之间的第 k 个最小距离。一对 (A, B) 的距离被定义为 A 和 B 之间的绝对差值。
		public int SmallestDistancePair(int[] nums, int k)
		{
			Array.Sort(nums);
			int left = 0, right = nums.Last() - nums[0], mid;
			

			while (left < right)
			{
				mid = left + (right - left) / 2;
				int res = FindDistanceShort(nums, mid);

				if (res < k) left = mid + 1;
				else right = mid;
			}
			return left;
		}

		public int FindDistanceShort(int[] nums,int distance)
		{
			int k = 0;
			int rightIndex = nums.Length - 1;
			for(int leftIndex = nums.Length - 2; leftIndex >= 0; leftIndex--)
			{
				while (rightIndex > leftIndex && nums[rightIndex] - nums[leftIndex] > distance)
				{
					rightIndex--;
				}
				k += rightIndex - leftIndex;
			}
			return k;
		}

		//static void Main(string[] args)
		//{
		//	var dsd = new FindK_thSmallestPairDistance_719();
		//	dsd.SmallestDistancePair(new int[] { 7, 2, 5, 10, 8 }, 2);
		//}
	}
}
