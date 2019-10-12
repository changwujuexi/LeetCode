using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetCode.array
{
    class ContainsDuplicate2_219
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Hashtable hashtable = new Hashtable();
            for(int i = 0; i < nums.Length; i++)
            {
                if (hashtable.Contains(nums[i])) return true;
                hashtable.Add(nums[i], i);
                if (hashtable.Count > k)
                {
                    hashtable.Remove(nums[i - k]);
                }
            }
            return false;

        }
    }
}
