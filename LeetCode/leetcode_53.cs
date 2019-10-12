using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class leetcode_53
    {
        public static int MaxSubArray(int[] nums)
        {
            var sum = nums[0];
            var result = sum;
            for(int i = 1; i < nums.Length; i++)
            {
                if (sum + nums[i] > nums[i])
                {
                    sum += nums[i];
                }
                else
                {
                    sum = nums[i];
                }
                result = result > sum ? result : sum;
            }
            return result;


        }
        //static void Main(string[] args)
        //{
        //    int num = MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
        //    Console.WriteLine(num);

        //    System.Console.ReadKey();
        //}

    }
    
}
