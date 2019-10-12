using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class FindPivotIndex_724
	{
		public int PivotIndex(int[] nums)
		{
			int addp = 0;
			int adda = 0;
			for(int i = 1; i < nums.Length; i++)
			{
				adda += nums[i];
			}
			for(int i = 0; i < nums.Length; i++)
			{
				if (adda == addp) return i;
				if (i == nums.Length - 1) return -1;
				addp += nums[i];
				adda -= nums[i + 1];
			}
			return -1;
		}
	}
}
