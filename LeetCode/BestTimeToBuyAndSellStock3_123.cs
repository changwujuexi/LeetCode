using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.array
{
    class BestTimeToBuyAndSellStock3_123
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;
            int K = 2;
            int[,] dp = new int[prices.Length, 3];
            for(int k = 1; k <= 2; k++)
            {
                int min = prices[0];
                for(int i = 1; i < prices.Length; i++)
                {
                    min = Math.Min(prices[i] - dp[i, k - 1], min);
                    
                    dp[i, k] = Math.Max(dp[i - 1, k], prices[i] - min);
                }
            }
            return dp[prices.Length - 1, K];
        }
    }
}
