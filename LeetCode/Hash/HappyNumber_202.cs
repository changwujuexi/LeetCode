﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
	class HappyNumber_202
	{
		//编写一个算法来判断一个数是不是“快乐数”。
		//一个“快乐数”定义为：对于一个正整数，每一次将该数替换为它每个位置上的数字的平方和，
		//然后重复这个过程直到这个数变为 1，也可能是无限循环但始终变不到 1。如果可以变为 1，那么这个数就是快乐数。
		public bool IsHappy(int n)
		{
			HashSet<int> set = new HashSet<int>();
			set.Add(n);
			while (true)
			{
				n = BitSquareSum(n);
				if (n == 1) return true;
				if (set.Contains(n)) return false;
				
				set.Add(n);
			}
			

		}
		public int BitSquareSum(int n)
		{
			int sum = 0;
			while (n > 0)
			{
				int bit = n % 10;
				sum += bit * bit;
				n = n / 10;
			}
			return sum;
		}

	}
}
