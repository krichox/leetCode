using System;

namespace DynamicPrograming.买卖股票的最佳时机
{
    /*https://leetcode.cn/problems/best-time-to-buy-and-sell-stock-ii/description/*/
    public class Best_Time_to_Buy_and_Sell_Stock_II买卖股票最佳时机2 {
        public int MaxProfit(int[] prices) {
            //var sumProfit = 0;
            //for(var i = 1; i < prices.Length; i++)
            //{
            //   sumProfit += Math.Max(prices[i] -  prices[i - 1], 0);
            //}
        
            //return sumProfit;


            // 动态规划方法
            // 定义dp数组 dp[i][0] 第i天，持有带来的最大收益
            // dp[i][1]第i天不持有带来的最大收益

            var dp = new int[prices.Length, 2];

            dp[0, 0] = -prices[0];
            dp[0, 1] = 0;

            for(var i = 1; i < prices.Length; i++)
            {
                dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] - prices[i]);
                dp[i, 1] = Math.Max(dp[i - 1, 1], dp[i - 1, 0] + prices[i]);
            }

            return dp[prices.Length - 1, 1];
        }
    }
}