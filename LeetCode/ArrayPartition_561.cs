﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.array
{
    class ArrayPartition_561
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
