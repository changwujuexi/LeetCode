using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.array
{
    class BestTimeToBuyAndSellStock2_122
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 1|| prices.Length == 0) return 0;
            int pre = prices[0];
            int max = 0;
            for(int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > pre)
                {
                    max += prices[i] - pre;
                    
                }
                pre = prices[i];
            }
            return max;
        }
    }
}
