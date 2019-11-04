using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class UniqueBinarySearchTrees_96
	{
		Dictionary<int,int> dic = new Dictionary<int, int>();

		public int NumTrees(int n)
		{
			int value;
			if (dic.TryGetValue(n, out value)) return value;

			int num = 0;
			if (n == 1)
			{
				dic.Add(1, 1);
				return 1;
			}
			num += NumTrees(n - 1);
			for(int i = 2; i < n; i++)
			{
				num += NumTrees(i - 1) * NumTrees(n - i);
			}
			num += NumTrees(n - 1);
			dic.Add(n, num);
			return num;
		}
	}
}
