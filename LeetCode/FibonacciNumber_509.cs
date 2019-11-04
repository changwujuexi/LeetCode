using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class FibonacciNumber_509
	{
		public int Fib(int N)
		{
			//带备忘录的动态规划。
			//return N - 2 >= 0 ? Fib(N - 1) + Fib(N - 2) : N;
			if (N < 2) return N;
			//自底向上
			//if (N < 2) return N;
			//int prev = 0, curr = 1;
			//for (int i = 0; i < N - 1; i++)
			//{
			//	int sum = prev + curr;
			//	prev = curr;
			//	curr = sum;
			//}
			//return curr;
			int[] memo = new int[N+1];
			return helper(memo, N);
		}

		public int helper(int[] memo,int N)
		{
			if (N <= 2) return 1;
			if (memo[N] != 0) return memo[N];
			memo[N] = helper(memo, N - 1) + helper(memo, N - 2);
			return memo[N];
		}
	}
}
