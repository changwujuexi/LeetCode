using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetCode.array
{
    class ContainsDuplicate_220
    {
        //桶排序，如果区间里包含两个元素，或者隔壁桶满足要求则true
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            if (t < 0) return false;
            Hashtable hashtable = new Hashtable();
            long w = (long)t + 1;
            for(int i = 0; i < nums.Length; ++i)
            {
                long m = GetID(nums[i], w);
                //检查桶m是不是空的，每个桶可能存在最多一个
                if (hashtable.ContainsKey(m)) return true;
                if (hashtable.ContainsKey(m - 1) && Math.Abs(nums[i] - (long)hashtable[m - 1]) < w) return true;
                if (hashtable.ContainsKey(m + 1) && Math.Abs(nums[i] - (long)hashtable[m + 1]) < w) return true;

                hashtable.Add(m, (long)nums[i]);
                if (i >= k) hashtable.Remove(GetID(nums[i - k], w));
            }
            return false;
        }

        private long GetID(long x,long w)
        {
            return x < 0 ? (x + 1) / w - 1 : x / w;
        }


    }
}
