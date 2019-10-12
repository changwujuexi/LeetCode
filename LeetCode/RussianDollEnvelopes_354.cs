using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class RussianDollEnvelopes_354
	{
		//给定一些标记了宽度和高度的信封，宽度和高度以整数对形式(w, h)出现。当另一个信封的宽度和高度都比这个信封大的时候，这个信封就可以放进另一个信封里，如同俄罗斯套娃一样。

		//请计算最多能有多少个信封能组成一组“俄罗斯套娃”信封（即可以把一个信封放到另一个信封里面）。

		//说明:
		//不允许旋转信封。

		//最长上升子序列
		public static int MaxEnvelopes(int[][] envelopes)
		{
			int l = envelopes.Length;
			if (l == 0) return 0;
			MergeSort(envelopes);
			
			int count = envelopes.Length;
			var last = new int[count];
			for(int i = 0; i < count; i++)
			{
				last[i] = envelopes[i][1];
			}
			return LengthOfLIS(last);
		}

		public static void MergeSort(int[][] arr)
		{
			Sort(arr, 0, arr.Length - 1);
		}

		public static void Sort(int[][] arr, int L, int R)
		{
			if (L == R) return;
			int mid = L + ((R - L) >> 1);
			Sort(arr, L, mid);
			Sort(arr, mid + 1, R);
			merge(arr, L, mid, R);
		}

		public static void merge(int[][]arr,int L,int mid, int R)
		{
			int[][] temp = new int[R - L + 1][];
			int i = 0;
			int p1 = L;
			int p2 = mid + 1;
			while (p1 <= mid && p2 <= R)
			{
				if (arr[p1][0] < arr[p2][0])
				{
					temp[i++] = arr[p1++];
				}
				else if (arr[p1][0] == arr[p2][0])
				{
					temp[i++] = arr[p1][1] < arr[p2][1] ? arr[p2++] : arr[p1++];
				}
				else
				{
					temp[i++] = arr[p2++];
				}
			}
			while (p1 <= mid) temp[i++] = arr[p1++];
			while (p2 <= R) temp[i++] = arr[p2++];
			for (i = 0; i < temp.Length; i++)
			{
				arr[L + i] = temp[i];
			}

		}

		public static int LengthOfLIS(int[] nums)
		{
			int l = nums.Length;
			if (l == 0) return 0;
			var tail = new int[l];
			tail[0] = nums[0];
			int k = 0;

			for (int i = 1; i < l; i++)
			{
				if (tail[0] > nums[i]) tail[0] = nums[i];
				else if (tail[k] < nums[i]) tail[++k] = nums[i];
				else
				{
					for (int j = 0; j <= k; j++)
					{
						if (tail[j] == nums[i]) break;
						if (tail[j] > nums[i])
						{
							tail[j] = nums[i];
							break;
						}
					}
				}				
			}
			return k + 1;

		}



		static void Main(string[] args)
		{
			Console.WriteLine(MaxEnvelopes(new int[20][] { new int[] { 15, 8 },new int[] { 2, 20 },new int[] { 2, 14 },new int[]{4,17 },
				new int[]{8,19 },new int[]{8,9 },new int[]{5,7 },new int[]{11,19 },new int[]{8, 11},new int[] { 13, 11},new int[]{2, 13},
				new int[]{11, 19},new int[]{8, 11},new int[]{13, 11},new int[]{2, 13},new int[]{11, 19},
				new int[]{16, 1},new int[] { 18, 13},new int[] { 14, 17},new int[] { 18, 19 }}));
			System.Console.ReadKey();
		}
	}

	
}
