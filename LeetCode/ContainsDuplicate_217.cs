using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.array
{
    class ContainsDuplicate_217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length == 0) return false;
            List<int> numsList = new List<int>(nums);
            numsList.Sort();
            var pre = numsList[0];
            for(int i = 1; i < numsList.Count; i++)
            {
                if (pre == numsList[i]) return true;
            }
            return false;
        }
    }
}
