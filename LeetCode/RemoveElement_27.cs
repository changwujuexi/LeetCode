using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class RemoveElement_27
	{
		//给定一个数组 nums和一个值 val，你需要原地移除所有数值等于 val的元素，返回移除后数组的新长度。

		//不要使用额外的数组空间，你必须在原地修改输入数组并在使用 O(1) 额外空间的条件下完成。

		//元素的顺序可以改变。你不需要考虑数组中超出新长度后面的元素。
		public int RemoveElement(int[] nums, int val)
		{
			int index1 = 0;
			int index2 = nums.Length - 1;
			int n = 0;
			while (index1 < index2)
			{
				if (nums[index1] == val)
				{
					n++;
					while (nums[index2] == val)
					{
						n++;
						index2--;
						if (index2 <= index1) return nums.Length - n;
					}
					
					nums[index1++] = nums[index2--];
				}
				else index1++;
			}
			if (index1 == index2)
			{
				if (nums[index1] == val) n++;
			}
			return nums.Length - n;
		}

		//static void Main(string[] args)
		//{
		//	var dsa = new RemoveElement_27();
		//	Console.WriteLine(dsa.RemoveElement(new int[] {3,3}, 3));
		//	Console.ReadKey();
		//}

	}
}
