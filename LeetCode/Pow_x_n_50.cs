using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class Pow_x_n__50
	{
		//实现 pow(x, n) ，即计算 x 的 n 次幂函数。
		public double MyPow(double x, int n)
		{
			if (n < 0)
			{
				x = 1 / x;
				n = -n;
			}
			return divide(x, n);
		}

		public double divide(double x, int n)
		{
			if (n == 0) return 1.0;
			var subResult = divide(x, n / 2);
			if (n % 2 != 0) return subResult * subResult * x;
			else return subResult * subResult;

		}
	}
}
