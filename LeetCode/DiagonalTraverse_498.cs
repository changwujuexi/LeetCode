using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetCode.array
{
    class DiagonalTraverse_498
    {


        public static int[] FindDiagonalOrder(int[,] matrix)
        {
            //if (matrix.Length == 0) return new int[] { };
            //int w = matrix.GetLength(0);
            //int h = matrix.Length;
            //int num = w * h;

            //ArrayList traverse = new ArrayList();

            //if (w < h)
            //{
            //    traverse.Add(matrix[0, 0]);
            //    bool flag = true;
            //    for (int i = 2; i <= w; i++)
            //    {
            //        if (flag == true)
            //        {
            //            for (int j = 0; j < i; j++)
            //            {
            //                traverse.Add(matrix[j, i - 1 - j]);
            //            }
            //        }
            //        if (flag == false)
            //        {
            //            for (int j = 0; j < i; j++)
            //            {
            //                traverse.Add(matrix[i - 1 - j, j]);
            //            }
            //        }
            //        flag = flag == true;
            //    }
            //    for (int l = w; l < h; l++)
            //    {
            //        if (flag == true)
            //        {
            //            for (int j = 0; j < w; j++)
            //            {
            //                traverse.Add(matrix[j + l - w, w - 1 - j]);
            //            }
            //        }
            //        if (flag == false)
            //        {
            //            for (int j = 0; j < w; j++)
            //            {
            //                traverse.Add(matrix[w - 1 - j, j + l - w]);
            //            }
            //        }
            //        flag = flag == true;
            //    }
            //    for (int i = w - 1; i > 0; i--)
            //    {
            //        if (flag == true)
            //        {
            //            for (int j = 0; j < i; j++)
            //            {
            //                traverse.Add(matrix[h - w + j, w - j]);
            //            }
            //        }
            //        if (flag == false)
            //        {
            //            for (int j = i-1; j >=0; j--)
            //            {
            //                traverse.Add(matrix[h - j - 1, j + 1]);
            //            }
            //        }
            //        flag = flag == true;
            //    }


            //}


            int M = matrix.Length;
            int N = matrix.GetLength(0);
            if (M == 0 || N == 0) return new int[] { };
            int row = 0;
            int col = 0;
            List<int> result = new List<int>();
            bool upFlag = true;
            
            while (true)
            {
                result.Add(matrix[row, col]);
                if (row == M - 1 && col == N - 1) return result.ToArray();

                if (upFlag)
                {
                    if (row == 0 && col < N - 1)
                    {
                        col += 1;
                        upFlag = false;
                    }
                    else if (col == N - 1)
                    {
                        row += 1;
                        upFlag = false;
                    }
                    else
                    {
                        row -= 1;
                        col += 1;
                    }

                }
                else
                {
                    if (col == 0 && row < M - 1)
                    {
                        row += 1;
                        upFlag = true;
                    }
                    else if (row == M - 1)
                    {
                        col += 1;
                        upFlag = true;
                    }
                    else
                    {
                        row += 1;
                        col -= 1;
                    }
                }
            }


        }




    }
}
