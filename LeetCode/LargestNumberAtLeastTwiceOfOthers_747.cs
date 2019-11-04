using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class LargestNumberAtLeastTwiceOfOthers_747
	{
		public int DominantIndex(int[] nums)
		{
			if (nums.Length == 0) return 1;
			int temp = nums[0];
			int index = 0;
			for(int i = 1; i < nums.Length; i++)
			{
				if (nums[i] > temp)
				{
					temp = nums[i];
					index = i;
				}
			}
			for(int i = 0; i < index; i++)
			{
				if (temp < nums[i] * 2) return -1;
			}
			for (int i = index+1; i < nums.Length; i++)
			{
				if (temp < nums[i] * 2) return -1;
			}
			return index;
		}
	}
}
