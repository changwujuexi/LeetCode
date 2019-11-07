using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
	class ValidSudoku_36
	{
		//判断一个 9x9 的数独是否有效。只需要根据以下规则，验证已经填入的数字是否有效即可。

		//数字 1-9 在每一行只能出现一次。
		//数字 1-9 在每一列只能出现一次。
		//数字 1-9 在每一个以粗实线分隔的 3x3 宫内只能出现一次。
		public bool IsValidSudoku(char[][] board)
		{
			HashSet<int>[] rows = new HashSet<int>[9];
			HashSet<int>[] cols = new HashSet<int>[9];
			HashSet<int>[] boxes = new HashSet<int>[9];

			for(int i = 0; i < 9; i++)
			{
				rows[i] = new HashSet<int>();
				cols[i] = new HashSet<int>();
				boxes[i] = new HashSet<int>();
			}

			for(int row = 0; row < 9; row++)
			{
				for(int col = 0; col < 9; col++)
				{
					char c = board[row][col];
					if (c == '.') continue;
					else
					{
						int num = c - '0';
						if (rows[row].Contains(num)) return false;
						if (cols[col].Contains(num)) return false;
						if (boxes[row / 3 * 3 + col / 3].Contains(num)) return false;

						rows[row].Add(num);
						cols[col].Add(num);
						boxes[row / 3 * 3 + col / 3].Add(num);

					}
					
				}
			}
			return true;
		}
	}
}
