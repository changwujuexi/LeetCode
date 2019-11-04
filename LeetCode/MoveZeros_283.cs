using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class MoveZeros_283
	{
		//给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。
		public void MoveZeroes(int[] nums)
		{
			int len = nums.Length;
			if (len != 0)
			{
				int i = 0;
				int j = 0;
				
				while (nums[j] != 0)
				{
					j++;
					if (j == len) break;
				}
				while (nums[i] == 0 || i < j)
				{
					i++;
					if (i == len) break;
				}
				while (i < len && j < len)
				{
					int temp = nums[i];
					nums[i] = nums[j];
					nums[j] = temp;
					i++;
					if (i == len) break;
					j++;
					if (j == len) break;
					
					while (nums[j] != 0)
					{
						j++;
						if (j == len) break;
					}
					while (nums[i] == 0 || i < j)
					{
						i++;
						if (i == len) break;
					}
					if (i == len) break;
					if (j == len) break;
				}





			}




		}
		//static void Main(string[] args)
		//{
		//	var sda = new MoveZeros_283();
		//	int[] nums = new int[] {1,0};
		//	sda.MoveZeroes(nums);
		//}
	}
}
