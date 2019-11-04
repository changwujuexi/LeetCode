using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class Pascal_sTriangle_118
	{
		//给定一个非负整数 numRows，生成杨辉三角的前 numRows 行。
		public IList<IList<int>> Generate(int numRows)
		{
			switch (numRows)
			{
				case 0:
					return new List<IList<int>> {};
				case 1:
					return new List<IList<int>> { new List<int> { 1 } };
				default:
					var pascal = new List<IList<int>> { new List<int> { 1 } };
					for (int i = 1; i < numRows; i++)
					{
						pascal.Add(new List<int> { 1 });
						for (int j = 1; j < i; j++) pascal[i].Add(pascal[i - 1][j - 1] + pascal[i - 1][j]);
						pascal[i].Add(1);
					}
					return pascal;
			}
		}
	}
}
