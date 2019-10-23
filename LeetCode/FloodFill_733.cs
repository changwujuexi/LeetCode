using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class FloodFill_733
	{
		//有一幅以二维整数数组表示的图画，每一个整数表示该图画的像素值大小，数值在 0 到 65535 之间。

		//给你一个坐标(sr, sc)表示图像渲染开始的像素值（行 ，列）和一个新的颜色值 newColor，让你重新上色这幅图像。

		//为了完成上色工作，从初始坐标开始，记录初始坐标的上下左右四个方向上像素值与初始坐标相同的相连像素点，
		//接着再记录这四个方向上符合条件的像素点与他们对应四个方向上像素值与初始坐标相同的相连像素点，……，重复该过程。将所有有记录的像素点的颜色值改为新的颜色值。

		//最后返回经过上色渲染后的图像。
		public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
		{
			if (image == null || image.Length == 0 || image[0].Length == 0 || image[sr][sc] == newColor) return image;
			int maxx = image.Length;
			int maxy = image[0].Length;
			int[,] cur = new int[maxx, maxy];
			var stack = new Stack<int[]>();
			stack.Push(new int[] { sr, sc });
			cur[sr, sc] = 1;
			var oldColor = image[sr][sc];
			image[sr][sc] = newColor;
			while (stack.Count != 0)
			{
				var place = stack.Pop();
				
				int leftx = place[0] - 1;
				int rightx = place[0] + 1;
				int upy = place[1] + 1;
				int downy = place[1] - 1;

				if (rightx < maxx)
				{
					if (cur[rightx, place[1]] == 0 && image[rightx][place[1]] == oldColor)
					{
						cur[rightx, place[1]] = 1;
						image[rightx][place[1]] = newColor;
						stack.Push(new int[] { rightx, place[1] });
					}
				}
				
				if (leftx >= 0)
				{
					if (cur[leftx, place[1]] == 0 && image[leftx][place[1]] == oldColor)
					{
						cur[leftx, place[1]] = 1;
						image[leftx][place[1]] = newColor;
						stack.Push(new int[] { leftx, place[1] });
					}
				}

				if (upy < maxy)
				{
					if (cur[place[0], upy] == 0 && image[place[0]][upy] == oldColor)
					{
						cur[place[0], upy] = 1;
						image[place[0]][upy] = newColor;
						stack.Push(new int[] { place[0], upy });
					}
				}

				if (downy >= 0)
				{
					if (cur[place[0], downy] == 0 && image[place[0]][downy] == oldColor)
					{
						cur[place[0], downy] = 1;
						image[place[0]][downy] = newColor;
						stack.Push(new int[] { place[0], downy });
					}
				}
				
			}
			return image;
		}

		//static void Main(string[] args)
		//{
		//	FloodFill_733 nus = new FloodFill_733();
		//	int[][] n = nus.FloodFill(new int[][] { new int[] { 1,1,1}, new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 } },1,1,2);
		//	Console.WriteLine(n);
		//	Console.ReadKey();
		//}

	}
}
