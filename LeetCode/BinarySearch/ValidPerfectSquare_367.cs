using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
	class ValidPerfectSquare_367
	{

		//给定一个正整数 num，编写一个函数，如果 num 是一个完全平方数，则返回 True，否则返回 False。
		public static bool IsPerfectSquare(int num)
		{
			if (num < 5)
			{
				if (num == 1 || num == 4) return true;
				return false;
			}
			long left = 0, right = num / 2;
			long mid = left + (right - left) / 2;
			while (left < right)
			{
				if (mid * mid == num) return true;
				if (mid * mid > num) right = mid;
				else left = mid + 1;
				mid = left + (right - left) / 2;
			}
			return mid * mid == num ? true : false;
		}
		//static void Main(string[] args)
		//{
		//	IsPerfectSquare(808201);
		//}
	}
}
