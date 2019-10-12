using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class FourSum_18
	{
		public static IList<IList<int>> FourSum(int[] nums, int target)
		{
			IList<IList<int>> ans = new List<IList<int>> { };
			if (nums == null) return ans;
			int len = nums.Length;
			if (len < 4) return ans;
			Array.Sort(nums);
			for(int i = 0; i < len - 3; i++)
			{
				
				if (i > 0 && nums[i - 1] == nums[i]) continue;
				for(int j = i + 1; j < len - 2; j++)
				{
					if (j - i > 1 && nums[j] == nums[j - 1]) continue;
					int L = j + 1;
					int R = len - 1;
					while (L < R)
					{
						int sum = nums[i] + nums[j] + nums[L] + nums[R];
						if (sum == target)
						{
							ans.Add(new List<int> { nums[i], nums[j], nums[L], nums[R] });
							while (L < R && nums[L + 1] == nums[L]) L++;
							while (L < R && nums[R - 1] == nums[R]) R--;
							L++;
							R--;
						}
						else if (sum < target) L++;
						else if (sum > target) R--;
					}
				}
			}
			return ans;
		}
		//static void Main(string[] args)
		//{
		//	IList<IList<int>> ans = FourSum(new int[] {-1,-5,-5,-3,2,5,0,4},-7);
		//	Console.WriteLine(ans);

		//	System.Console.ReadKey();
		//}

	}

	

}

