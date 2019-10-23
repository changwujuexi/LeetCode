using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class NumberOfIslands_UnionFind
	{
		public int NumIslands(char[][] grid)
		{
			int rows = grid.Length;
			if (rows == 0) return 0;
			int cols = grid[0].Length;
			int[,] union = new int[rows, cols];
			int count = 0;
			for(int i = 0; i < rows; i++)
			{
				for(int j = 0; j < cols; j++)
				{
					if (grid[i][j] == '1')
					{
						if (count == 0)
						{
							union[i, j] = 1;
							count++;
						}
						if (union[i, j] == 0)
						{
							union[i, j] = ++count;
						}
						if (i + 1 < rows && grid[i + 1][j] == '1')
						{
							if (union[i + 1, j] != 0)
							{
								int res = i + 1;
								while (res >= 0)
								{
									union[res - 1, j] = union[res, j];
									res--;
								}
							}
							union[i + 1, j] = union[i, j];
						}
						if (j + 1 < cols && grid[i][j + 1] == '1')
						{
							union[i, j + 1] = union[i, j];
						}
						

					}
				}
			}

			return count;

		}


		//public static void Main(string[] args)
		//{
		//	NumberOfIslands_UnionFind num = new NumberOfIslands_UnionFind();
		//	char[][] grid1 = new char[][]{
		//		new char[]{'1', '1', '0', '0', '0'},
		//		new char[]{'1', '1', '0', '0', '0'},
		//		new char[]{'0', '0', '1', '0', '0'},
		//		new char[]{'0', '0', '0', '1', '1'}};
		//	Console.WriteLine(num.NumIslands(grid1));
		//	Console.ReadKey();

		//}

	}
}
