using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LC2018.Prepare
{
	class MajorityElement_169
	{
		//给定一个大小为 n 的数组，找到其中的多数元素。多数元素是指在数组中出现次数大于 ⌊ n/2 ⌋ 的元素。
		//你可以假设数组是非空的，并且给定的数组总是存在多数元素。
		public int MajorityElement(int[] nums)
		{
			int num = 1;
			int temp = nums[0];
			for(int i = 1; i < nums.Length; i++)
			{
				if (temp == nums[i]) num++;
				else
				{
					num--;
					if (num < 0) temp = nums[i + 1];
				}
			}
			return num;
		}

	}
}
