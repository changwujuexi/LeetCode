using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class NumberOfIsland_BFS
	{
		public int NumIslands(char[][] grid)
		{
			int rows = grid.Length;
			if (rows == 0) return 0;
			int cols = grid[0].Length;
			int[,] marked = new int[grid.Length, grid[0].Length];
			int count = 0;

			for(int i = 0; i < rows; i++)
			{
				for(int j = 0; j < cols; j++)
				{
					if (marked[i, j] != -1 && grid[i][j] == '1')
					{
						count++;
						var list = new List<KeyValuePair<int, int>>();
						marked[i, j] = -1;

						list.Add(new KeyValuePair<int, int>(i, j));
						while (list.Count != 0)
						{
							int curX = list[0].Key;
							int curY = list[0].Value;
							list.RemoveAt(0);

							int leftX = curX - 1;
							int rightX = curX + 1;
							int upY = curY + 1;
							int downY = curY - 1;
							if (leftX >= 0 && grid[leftX][curY] == '1' && marked[leftX, curY] != -1)
							{
								list.Add(new KeyValuePair<int, int>(leftX, curY));
								marked[leftX, curY] = -1;
							}
							if (rightX <= rows && grid[rightX][curY] == '1' && marked[rightX, curY] != -1)
							{
								list.Add(new KeyValuePair<int, int>(rightX, curY));
								marked[rightX, curY] = -1;
							}

							if (upY <= cols && grid[curX][upY] == '1' && marked[curX, upY] != -1)
							{
								list.Add(new KeyValuePair<int, int>(curX, upY));
								marked[curX, upY] = -1;
							}
							
							if (downY >= 0 && grid[curX][downY] == '1' && marked[curX, downY] != -1)
							{
								list.Add(new KeyValuePair<int, int>(curX, downY));
								marked[curX, downY] = -1;
							}

						}
					}
				}
			}

			return count;
		}
	}
}
