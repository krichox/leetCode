using System;

namespace DynamicPrograming.买卖股票的最佳时机
{
    /*https://leetcode.cn/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/description/*/
    public class Best_Time_to_Buy_and_Sell_Stock_with_Transaction_Fee买卖股票的最佳时机含手续费 {
        public int MaxProfit(int[] prices, int fee) {
            var dp = new int[prices.Length, 2];

            if(prices.Length == 1)
            {
                return 0;
            }
            dp[0, 0] = -prices[0];
            // 非法值，初始化为0
            dp[0, 1] = 0;
            for(var i = 1; i < prices.Length; i++)
            {
                dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] - prices[i]);
                dp[i, 1] = Math.Max(dp[i - 1, 1], dp[i - 1, 0] + prices[i] - fee);
            }
            
            // 可能为负数
            return Math.Max(dp[prices.Length - 1, 1], 0);
        }
    }
}