using System;

namespace DynamicPrograming.买卖股票的最佳时机
{
    /*https://leetcode.cn/problems/best-time-to-buy-and-sell-stock-with-cooldown/description/*/
    public class Best_Time_to_Buy_and_Sell_Stock_with_Cooldown买卖股票最佳时期含冷冻期 {
        public int MaxProfit(int[] prices) {
            // 定义dp数组，4种状态
            // 0： 持股状态
            // 1:  不持股状态
            // 2:  卖出状态
            // 3:  冷冻期
            var dp = new int[prices.Length, 4];

            if(prices.Length == 1)
            {
                return 0;
            }

            dp[0, 0] = -prices[0];
            dp[0, 1] = 0;
            dp[0, 2] = 0;
            dp[0, 3] = 0;

            for(var i = 1; i < prices.Length; i++)
            {
                dp[i, 0] = Math.Max(dp[i - 1, 0], Math.Max(dp[i - 1, 1]  - prices[i] , dp[i - 1, 3]  - prices[i]));
                dp[i, 1] = Math.Max(dp[i - 1, 1], dp[i - 1, 3]);
                dp[i, 2] = dp[i - 1, 0] + prices[i];
                dp[i, 3] = dp[i - 1, 2];
            }

            return Math.Max(dp[prices.Length - 1, 3], Math.Max(dp[prices.Length - 1, 1], dp[prices.Length - 1, 2]));
        }
    }
}