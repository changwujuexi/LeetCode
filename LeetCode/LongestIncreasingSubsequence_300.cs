using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class LongestIncreasingSubsequence_300
	//给定一个无序的整数数组，找到其中最长上升子序列的长度。
	{
		public static int LengthOfLIS(int[] nums)
		{
			int l = nums.Length;
			if (l == 0) return 0;
			var tail = new int[l];
			tail[0] = nums[0];
			int k = 0;
			
			for(int i = 1; i < l; i++)
			{
				int res = BinarySeach(tail, nums[i], 0, k);
				if (res == int.MaxValue)
				{
					tail[0] = nums[i];
				}
				else if (res == k)
				{
					tail[++k] = nums[i];
				}else if (res == int.MinValue)
				{
					continue;
				}
				else
				{
					tail[res + 1] = nums[i];
				}
			}
			return k + 1;

		}

		public static int BinarySeach(int[] tail, int temp, int begin, int end)
		{
			//返回下一个大于nums[i]，这个小于nums[i]的tail[k]的k
			//如果都大于，说明tail[0]也大于，返回int.MaxValue
			//如果都小于，即tail[end]小于，返回end
			if (tail[end] < temp) return end;
			if (begin == end)
			{
				if (tail[begin] > temp) return int.MaxValue;
				if (tail[begin] == temp) return int.MinValue;
			}
			int mid = (end + begin) / 2;
			if (tail[mid] > temp) return BinarySeach(tail, temp, begin, mid);

			if (tail[mid] < temp)
			{
				if (tail[mid + 1] > temp) return mid;
				else return BinarySeach(tail, temp, mid, end);
			}
			return int.MinValue;
		}
		//static void Main(string[] args)
		//{
		//	Console.WriteLine(LengthOfLIS(new int[] { 2,2}));
		//	System.Console.ReadKey();
		//}
	}
}
