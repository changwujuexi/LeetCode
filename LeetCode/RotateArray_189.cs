using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class RotateArray_189
	{
		//给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数。
		public void Rotate(int[] nums, int k)
		{
			int len = nums.Length;
			k = k % len;
			if (k != 0)
			{
				int r = 0;
				int a = len;
				int b = k;
				while (b != 0)
				{
					r = a % b;
					a = b;
					b = r;
				}
				if (a == 1)
				{
					int start = 0;
					int prev = nums[start];
					int cur = start;
					cur = (start + k) % len;
					while (cur != start)
					{
						int temp = nums[cur];
						nums[cur] = prev;
						prev = temp;
						cur = (cur + k) % len;
					}
					nums[cur] = prev;
				}
				else
				{
					for (int i = 0; i < r; i++)
					{
						int start = i;
						int prev = nums[start];
						int cur = start;
						cur = (start + k) % len;
						while (cur != start)
						{
							int temp = nums[cur];
							nums[cur] = prev;
							prev = temp;
							cur = (cur + k) % len;
						}
						nums[cur] = prev;
					}
				}
			}
			
			



		}

		//static void Main(string[] args)
		//{
		//	var sda = new RotateArray_189();
		//	int[] nums = new int[] { 1, 2, 3, 4, 5, 6};
		//	sda.Rotate(nums, 2);
		//}

	}
}
