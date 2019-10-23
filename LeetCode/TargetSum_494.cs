using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class TargetSum_494
	{
		//给定一个非负整数数组，a1, a2, ..., an, 和一个目标数，S。现在你有两个符号 + 和 -。对于数组中的任意一个整数，你都可以从 + 或 -中选择一个符号添加在前面。
		//返回可以使最终数组和为目标数 S 的所有添加符号的方法数。
		//DFS
		public int FindTargetSumWays(int[] nums, int S)
		{
			return FindTargetSumWays(nums, 0, S);
		}

		private int FindTargetSumWays(int[] nums, int start, int S)
		{
			if (start == nums.Length)
			{
				return S == 0 ? 1 : 0;
			}
			return FindTargetSumWays(nums, start + 1, S + nums[start]) + FindTargetSumWays(nums, start + 1, S - nums[start]);
		}

		public int FindTargetSumWays_DP(int[] nums, int S)
		{
			int sum = 0;
			foreach(int num in nums)
			{
				sum += num;
			}
			if (sum < S || (sum + S) % 2 == 1) return 0;
			S = (sum + S) / 2;
			int[] dp = new int[S + 1];
			dp[0] = 1;
			foreach(int num in nums)
			{
				for(int i = S; i >= num; i--)
				{
					dp[i] += dp[i - num];
				}
			}
			return dp[S];
		}

		//static void Main(string[] args)
		//{
		//	TargetSum_494 nus = new TargetSum_494();
		//	int n = nus.FindTargetSumWays_DP(new int[] { 1, 1, 1, 1, 1 }, 3);
		//	Console.WriteLine(n);
		//	Console.ReadKey();
		//}
	}
}
