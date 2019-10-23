using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class PerfectSquares_279
	{
		public int NumSquares(int n)
		{
			int[] memo = new int[n + 1];
			for (int i = 0; i < n + 1; i++) memo[i] = i;

			for(int i = 2; i <= n; i++)
			{
				for(int j = 1; j * j <= i; j++)
				{
					memo[i] = Math.Min(memo[i], memo[i - j * j] + 1);
				}
			}
			return memo[n];
		}
	}
}
