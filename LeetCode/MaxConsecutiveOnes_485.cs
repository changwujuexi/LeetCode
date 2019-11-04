using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class MaxConsecutiveOnes_485
	{
		//给定一个二进制数组， 计算其中最大连续1的个数。
		public int FindMaxConsecutiveOnes(int[] nums)
		{
			int len = nums.Length;
			int i = 0;
			int maxtemp = 0;
			int temp = 0;
			int n = 0;
			while (i < len)
			{
				while (nums[i] != 1 && i < len)
				{
					i++;
					if (i == len) return maxtemp;

				}
				
				while (nums[i] == 1)
				{
					i++;
					temp++;
					if (i == len) break;
				}
				if (maxtemp < temp) maxtemp = temp;
				temp = 0;
			}
			return maxtemp;
		}
	}
}
