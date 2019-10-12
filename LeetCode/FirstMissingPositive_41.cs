using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class FirstMissingPositive_41
	{
		public int FirstMissingPositive(int[] nums)
		{
			int[] temp = new int[nums.Length];
			for(int i = 0; i < nums.Length; i++)
			{
				if (nums[i] > 0 && nums[i] < nums.Length)
				{
					temp[nums[i] - 1] = nums[i];
				}
			}
			for(int i = 0; i < nums.Length; i++)
			{
				if (temp[i] != i + 1) return i + 1;
			}
			return nums.Length + 1;
		}
	}
}
