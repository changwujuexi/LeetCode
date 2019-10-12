using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class leetcode_70
    {
        public int ClimbStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int[] num = new int[n+1];
            num[1] = 1;
            num[2] = 2;
            for(int i = 3; i <= n; i++)
            {
                num[i] = num[i - 1] + num[i - 2] + 2;
            }
            return num[n];
        }
    }
}
