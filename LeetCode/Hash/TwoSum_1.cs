using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
	class TwoSum_1
	{
		public int[] TwoSum(int[] nums, int target)
		{
			Hashtable table = new Hashtable();
			for(int i = 0; i < nums.Length; i++)
			{
				if (table.ContainsKey(target - nums[i])) return new int[] { i, (int)table[target - nums[i]] };
				if (table.ContainsKey(nums[i])) continue;
				table.Add(nums[i], i);
			}
			return new int[] { };
		}
	}
}
