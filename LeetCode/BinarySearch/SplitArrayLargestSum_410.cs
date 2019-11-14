using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
	class SplitArrayLargestSum_410
	{
		public int SplitArray(int[] nums, int m)
		{
			//给定一个非负整数数组和一个整数 m，你需要将这个数组分成 m个非空的连续子数组。设计一个算法使得这 m个子数组各自和的最大值最小。

			//注意:
			//	数组长度 n满足以下条件:

			//	1 ≤ n ≤ 1000
			//  1 ≤ m ≤ min(50, n)
			long left = 0;
			long right = 0;
			long mid;
			int len = nums.Length;
			for (int i = 0; i < len; i++)
			{
				right += nums[i];
				left = left < nums[i] ? nums[i] : left;
			}

			long ans = right;
			while (left <= right)
			{
				mid = left + (right - left) / 2;
				long sum = 0;
				long cut = 1;
				for (int i = 0; i < len; i++)
				{
					if (sum + nums[i] > mid)
					{
						cut++;
						sum = nums[i];
					}
					else sum += nums[i];
				}
				if (cut <= m)
				{
					ans = mid;
					right = mid - 1;
				}
				else left = mid + 1;
			}
			return (int)ans;
		}
		
	}
}
