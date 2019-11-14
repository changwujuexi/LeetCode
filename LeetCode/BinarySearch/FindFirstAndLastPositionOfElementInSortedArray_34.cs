using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
	class FindFirstAndLastPositionOfElementInSortedArray_34
	{
		//给定一个按照升序排列的整数数组 nums，和一个目标值 target。找出给定目标值在数组中的开始位置和结束位置。

		//你的算法时间复杂度必须是 O(log n) 级别。

		//如果数组中不存在目标值，返回[-1, -1]。
		public static int[] SearchRange(int[] nums, int target)
		{
			if (nums.Length == 0) return new int[2] { -1, -1 };
			if (nums.Length == 1)
			{
				if (nums[0] == target) return new int[2] { 0, 0 };
				else return new int[2] { -1, -1 };
			}
			int left = 0;
			int right = nums.Length - 1;
			int mid = left + (right - left) / 2;

			int[] n = new int[2];

			while (nums[mid] != target)
			{if (!(right > left)) return new int[] { -1, -1 };
				if (nums[mid] > target) right = mid - 1;
				else { left = mid + 1; }
				mid = left + (right - left) / 2;
			}

			int flag = 0;
			left = 0;
			right = mid;
			int mid2 = left + (right - left) / 2;
			if (right == left) { n[0] = mid2; flag = 1; }
			if (nums[0] == target) { n[0] = 0;flag = 1; }
			if (flag != 1)
			{
				while (right > left)
				{
					if (nums[mid2] == target) right = mid2;
					else if (nums[mid2] < target && nums[mid2 + 1] == target)
					{
						n[0] = mid2 + 1;
						flag = 1;
						break;
					}
					else
					{
						left = mid2 + 1;
					}
					mid2 = left + (right - left) / 2;
				}
				if (flag == 0) n[0] = mid2 + 1;
			}

			left = mid;
			right = nums.Length - 1;
			mid2 = left + (right - left) / 2;
			flag = 0;

			while (right > left)
			{
				if (nums[mid2] != target) right = mid2;
				else if (nums[mid2 + 1] > target)
				{
					n[1] = mid2;
					flag = 1;
					break;
				}
				else
				{
					left = mid2 + 1;
				}
				mid2 = left + (right - left) / 2;
			}
			if (flag == 0) n[1] = mid2;

			return n;
		}

		//static void Main(string[] args)
		//{
		//	int[] i = new int[3] {1,1,2};
		//	SearchRange(i, 1);
		//}
	}
}
