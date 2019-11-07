using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
	class IntersectionOfTwoArraysII_350
	{
		//给定两个数组，编写一个函数来计算它们的交集。
		//说明：

		//输出结果中每个元素出现的次数，应与元素在两个数组中出现的次数一致。
		//我们可以不考虑输出结果的顺序。

		//进阶:

		//如果给定的数组已经排好序呢？你将如何优化你的算法？
		//如果 nums1的大小比 nums2小很多，哪种方法更优？
		//如果 nums2的元素存储在磁盘上，磁盘内存是有限的，并且你不能一次加载所有的元素到内存中，你该怎么办？
		public int[] Intersect(int[] nums1, int[] nums2)
		{
			Hashtable hs = new Hashtable();
			for(int i = 0; i < nums1.Length; i++)
			{
				if (hs.ContainsKey(nums1[i])) hs[nums1[i]] = (int)hs[nums1[i]] + 1;
				else hs.Add(nums1[i], 1);
			}

			List<int> list = new List<int>();

			for(int j = 0; j < nums2.Length; j++)
			{
				if (hs.ContainsKey(nums2[j]))
				{
					list.Add(nums2[j]);
					if ((int)hs[nums2[j]] == 1) hs.Remove(nums2[j]);
					else hs[nums2[j]] = (int)hs[nums2[j]] - 1;
				}				
			}

			return list.ToArray();



		}

	}
}
