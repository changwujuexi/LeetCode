using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class _01Matrix_542
	{
		//给定一个由 0 和 1 组成的矩阵，找出每个元素到最近的 0 的距离。
		//两个相邻元素间的距离为 1 。
		public int[][] UpdateMatrix(int[][] matrix)
		{
			for(int i = 0; i < matrix.Length; i++)
			{
				for(int j = 0; j < matrix[0].Length; j++)
				{
					int row = 10001;
					int col = 10001;
					if (matrix[i][j] != 0)
					{
						if (i > 0) col = matrix[i - 1][j];
						if (j > 0) row = matrix[i][j - 1];
						matrix[i][j] = Math.Min(row, col) + 1;
					}
				}
			}
			for (int i = matrix.Length - 1; i >= 0; i--)
			{
				for(int j = matrix[0].Length - 1; j >= 0; j--)
				{
					int row = 10001;
					int col = 10001;
					if (matrix[i][j] != 0)
					{
						if (i < matrix.Length - 1) col = matrix[i + 1][j];
						if (j < matrix[0].Length - 1) row = matrix[i][j + 1];
						matrix[i][j] = Math.Min(matrix[i][j], Math.Min(col, row) + 1);
					}
				}
			}
			return matrix;
		}
	}
}
