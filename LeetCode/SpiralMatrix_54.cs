using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class SpiralMatrix_54
	{
		public IList<int> SpiralOrder(int[][] matrix)
		{
			var ans = new List<int>();
			if (matrix.Length == 0) return ans;
			int row = matrix.Length;
			int col = matrix[0].Length;
			int[] dr = { 0, 1, 0, -1 };
			int[] dc = { 1, 0, -1, 0 };
			int r = 0;
			int c = 0;
			int di = 0;
			for(int i = 0; i < row * col; i++)
			{
				ans.Add(matrix[r][c]);
				matrix[r][c] = 0;
				int cr = r + dr[di];
				int cc = c + dc[di];
				if (cr >= 0 && cr < row && cc >= 0 && cc < col && matrix[cr][cc] != 0)
				{
					r = cr;
					c = cc;
				}
				else
				{
					di = (di + 1) % 4;
					r += dr[di];
					c += dc[di];
				}
			}
			return ans;
		}
	}
}
