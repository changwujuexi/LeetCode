using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
	class FindMinimumInRotatedSortedArray
	{
		//假设按照升序排序的数组在预先未知的某个点上进行了旋转。

		//( 例如，数组[0, 1, 2, 4, 5, 6, 7] 可能变为[4, 5, 6, 7, 0, 1, 2])。

		//请找出其中最小的元素。

		//你可以假设数组中不存在重复元素。

		public int FindMin(int[] nums)
		{
			int left = 0, right = nums.Length - 1;
			int mid = left + (right - left) / 2;
			while (right > left)
			{
				if (nums[mid] > nums[right]) left = mid + 1;
				else right = mid;
				mid = left + (right - left) / 2;
			}
			return nums[left];
		}
	}
}
