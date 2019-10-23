using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class NumberOfIslands
	{
		//给定一个由 '1'（陆地）和 '0'（水）组成的的二维网格，计算岛屿的数量。一个岛被水包围，并且它是通过水平方向或垂直方向上相邻的陆地连接而成的。你可以假设网格的四个边均被水包围。

		//DFS

		int[,] marked;
		char[][] grid;

		public int NumIslands(char[][] grid)
		{
			this.grid = grid;
			int rows = grid.Length;
			if (rows == 0) return 0;
			int cols = grid[0].Length;
			marked = new int[grid.Length,grid[0].Length];

			int count = 0;
			for(int i = 0; i < rows; i++)
			{
				for(int j = 0; j < cols; j++)
				{
					if (marked[i,j] != -1 && grid[i][j] == '1')
					{
						count++;
						Dfs(i, j);
					}
				}
			}
			return count;

		}

		public void Dfs(int i,int j)
		{
			marked[i,j] = -1;
			int leftX = i - 1;
			int rightX = i + 1;
			int upY = j + 1;
			int downY = j - 1;
			if (leftX >= 0 && grid[leftX][j] == '1' && marked[leftX,j] != -1)
			{
				Dfs(leftX, j);
			}
			if (rightX < grid.Length && grid[rightX][j] == '1' && marked[rightX,j] != -1)
			{
				Dfs(rightX, j);
			}
			if (upY < grid[0].Length && grid[i][upY] == '1' && marked[i,upY] != -1)
			{
				Dfs(i, upY);
			}
			if (downY >= 0 && grid[i][downY] == '1' && marked[i,downY] != -1)
			{
				Dfs(i, downY);
			}
		}

		//public static void Main(string[] args)
		//{
		//	NumberOfIslands num = new NumberOfIslands();
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
