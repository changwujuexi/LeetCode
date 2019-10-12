using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class FindTheDuplicateNumber_287
	{
		public int FindDuplicate(int[] nums)
		{
			int tor = nums[0];
			int hare = nums[0];
			do
			{
				tor = nums[tor];
				hare = nums[nums[hare]];
			} while (tor != hare);

			int ptr1 = nums[0];
			int ptr2 = tor;
			while (ptr1 != ptr2)
			{
				ptr1 = nums[ptr1];
				ptr2 = nums[ptr2];
			}
			return ptr1;
		}
	}
}
