using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class mi20190911
    {
        static void QuickSort(int[] nums, int left, int right)
        {
            if (left < right)
            {
                int i = left;
                int j = right;
                int middle = nums[(left + right) / 2];
                while (true)
                {
                    while (i < right && nums[i] < middle) { i++; };
                    while (j > 0 && nums[j] > middle) { j--; };
                    if (i == j) break;
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    if (nums[i] == nums[j]) j--;
                }
                QuickSort(nums, left, i);
                QuickSort(nums, i + 1, right);
            }
        }

        static int solution(List<int> array)
        {



            if (array.Count == 0|| array.Count == 1|| array.Count == 2)
            {
                return 0;
            }
            int num1 = 0;

            var array1 = array;
            var arrayp = array;
            array1.Reverse();
            var arraypd = array1;

            for (int j = 0; j < array.Count - 1; j++)
            {
                for(int i = 0; i < array.Count; i++)
                {
                    if (array[j] > array[i])
                    {
                        if (i == array.Count - 1)
                        {
                            var temp = array[j];
                            array.RemoveAt(j);
                            array.Insert(i, temp);
                            num1++;
                        }
                        else if (array[i + 1] > array[j])
                        {
                            var temp = array[j];
                            array.RemoveAt(j);
                            array.Insert(i, temp);
                            num1++;
                        }
                    }
                }
                
            }

            

            int num2 = 0;
            for (int j = 0; j < array1.Count - 1; j++)
            {
                for (int i = j + 1; i < array1.Count; i++)
                {
                    if (array1[j] > array1[i])
                    {
                        if (i == array1.Count - 1)
                        {
                            var temp = array1[j];
                            array1.RemoveAt(j);
                            array1.Insert(i, temp);
                            num2++;
                        }
                        else if (array1[i + 1] > array1[j])
                        {
                            var temp = array1[j];
                            array1.RemoveAt(j);
                            array1.Insert(i, temp);
                            num2++;
                        }

                    }
                }
            }
            return num1 <= num2 ? num1 : num2;

        }

        //static void Main(string[] args)
        //{
        //    List<int> li = new List<int> {8,7,10,5,4};
        //    int num = solution(li);
        //    Console.WriteLine(num);
        //    Console.ReadKey();
        //}



    }
}
