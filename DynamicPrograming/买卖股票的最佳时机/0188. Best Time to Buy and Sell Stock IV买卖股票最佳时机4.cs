using System;

namespace DynamicPrograming.买卖股票的最佳时机
{
    /*https://leetcode.cn/problems/best-time-to-buy-and-sell-stock-iv/description/*/
    public class Best_Time_to_Buy_and_Sell_Stock_IV买卖股票最佳时机4 {
        public int MaxProfit(int k, int[] prices) {
            var dp =  new int[prices.Length, 2 * k + 1];

            // dp[i][0] 第i天，不操作的最大利润
            // dp[i][1] 第i天，第一次持有的最大利润
            // dp[i][2] 第i天，第一次不持有的最大利润
            // dp[i][3] 第i天，第二次持有的最大利润
            // dp[i][4] 第i天，第二次不持有的最大利润
            // ....  
            // dp[i][2k] 第i天，第k次不持有的最大利润  

            if(prices.Length == 1)
            {
                return 0;
            }
            // 初始化
            for(var i = 1; i < 2 * k + 1; i += 2)
            {
                dp[0, i] = -prices[0]; 
            }

            for(var i = 1; i < prices.Length; i++)
            {
                for(var j = 0; j < 2 * k - 1; j+=2)
                {
                    dp[i, j + 1] = Math.Max(dp[i - 1, j + 1], dp[i - 1, j] - prices[i]);
                    dp[i, j + 2] = Math.Max(dp[i - 1, j + 2], dp[i - 1, j + 1] + prices[i]);
                }
            }

            return dp[prices.Length - 1, 2 * k];
        }
    }
}