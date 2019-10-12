using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class ThreeSum_15
	{
		public IList<IList<int>> ThreeSum(int[] nums)
		{
			IList<IList<int>> ans = new List<IList<int>> { };
			if (nums == null) return ans;			
			int len = nums.Length;
			if (len < 3) return ans; 
			Array.Sort(nums);
			for(int i = 0; i < len; i++)
			{
				if (nums[i] > 0) break;
				if (i > 0 && nums[i] == nums[i - 1]) continue;
				int L = i + 1;
				int R = len - 1;
				while (L < R)
				{
					int sum = nums[i] + nums[L] + nums[R];
					if (sum == 0)
					{
						ans.Add(new List<int> { nums[i], nums[L], nums[R] });
						while (L < R && nums[L] == nums[L + 1]) L++;
						while (L < R && nums[R] == nums[R - 1]) R--;
						L++;
						R--;
					}
					else if (sum < 0) L++;
					else if (sum > 0) R--;
					
				}
			}
			return ans;

		}
	}
}
