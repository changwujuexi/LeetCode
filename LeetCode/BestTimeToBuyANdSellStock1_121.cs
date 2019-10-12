using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.array
{
    class BestTimeToBuyANdSellStock1_121
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1) return 0;
            int max = 0;
            int min = prices[0];
            for(int i = 1; i < prices.Length; i++)
            {
                
                max = Math.Max(prices[i] - min, max);
                if (prices[i] < min) min = prices[i];
            }
            return max;
        }
    }
}
