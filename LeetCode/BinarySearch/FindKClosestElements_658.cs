using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
	class FindKClosestElements_658
	{
		//给定一个排序好的数组，两个整数 k 和 x，从数组中找到最靠近 x（两数之差最小）的 k 个数。
		//返回的结果必须要是按升序排好的。如果有两个数与 x 的差值一样，优先选择数值较小的那个数。
		public IList<int> FindClosestElements(int[] arr, int k, int x)
		{
			int left = 0, right = arr.Length - k;
			int mid = left + (right - left) / 2;
			while (right > left)
			{
				if (x - arr[mid] > arr[mid + k] - x) left = mid + 1;
				else right = mid;
				mid = left + (right - left) / 2;
			}
			List<int> list = new List<int>();
			for (int i = mid; i < mid + k; i++) list.Add(arr[i]);
			return list;
		}
	}
}
