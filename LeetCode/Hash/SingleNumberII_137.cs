using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
	class SingleNumberII_137
	{
		//给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现了三次。找出那个只出现了一次的元素。

		//说明：

		//你的算法应该具有线性时间复杂度。 你可以不使用额外空间来实现吗？
		public int SingleNumber(int[] nums)
		{
			int a = 0, b = 0;
			foreach(int num in nums)
			{
				b = (b ^ num) & ~a;
				a = (a ^ num) & ~b;
			}
			return b;
		}
	}
}
