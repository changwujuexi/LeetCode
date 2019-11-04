using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class MinimumSizeSubarraySum_209
	{
		//给定一个含有 n 个正整数的数组和一个正整数 s ，找出该数组中满足其和 ≥ s 的长度最小的连续子数组。如果不存在符合条件的连续子数组，返回 0。
		public int MinSubArrayLen(int s, int[] nums)
		{
			int n = nums.Length;
			int ans = int.MaxValue;
			int left = 0;
			int sum = 0;
			for(int i = 0; i < n; i++)
			{
				sum += nums[i];
				while (sum >= s)
				{
					ans = Math.Min(ans, i + 1 - left);
					sum -= nums[left++];
				}
			}
			return (ans != int.MaxValue) ? ans : 0;


		}
	}
}
