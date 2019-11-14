using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
	class Sqrt_x__69
	{
		//实现 int sqrt(int x)函数。
		//计算并返回 x的平方根，其中 x 是非负整数。
		//由于返回类型是整数，结果只保留整数的部分，小数部分将被舍去。
		public int MySqrt(int x)
		{
			long left = 0, right = x / 2 + 1;
			while (left < right)
			{
				long mid = (left + right + 1) / 2;
				long square = mid * mid;
				if (square > x) right = mid - 1;
				else left = mid;
			}
			return (int)left;
		}

		//static void Main(string[] args)
		//{
		//	MySqrt(21);
		//}

	}
}
