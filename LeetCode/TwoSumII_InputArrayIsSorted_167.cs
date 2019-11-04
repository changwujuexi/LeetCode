using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class TwoSumII_InputArrayIsSorted_167
	{
		//给定一个已按照升序排列 的有序数组，找到两个数使得它们相加之和等于目标数。

		//函数应该返回这两个下标值 index1 和 index2，其中 index1必须小于 index2。

		//说明:

		//返回的下标值（index1 和 index2）不是从零开始的。
		//你可以假设每个输入只对应唯一的答案，而且你不可以重复使用相同的元素。
		public int[] TwoSum(int[] numbers, int target)
		{
			int index1 = 0;
			int index2 = numbers.Length - 1;
			while (index1 < index2)
			{
				if (target == numbers[index1] + numbers[index2]) return new int[] { index1 + 1, index2 + 1 };
				else if (target < numbers[index1] + numbers[index2]) index2--;
				else index1++;
			}
			return new int[] { };
		}

	}
}
