using System;

namespace DynamicPrograming.买卖股票的最佳时机
{
    public class Best_Time_to_Buy_and_Sell_Stock买卖股票最佳时机1 {
        public int MaxProfit(int[] prices) {
            // 贪心算法，取左最小值，取右最大值

            var low = int.MaxValue;
            var result = 0;
            for(var i = 0; i < prices.Length; i++)
            {
                low = Math.Min(low, prices[i]);
                result = Math.Max(result, prices[i] - low);
            }

            return result;

        }
        
        public int MaxProfit2(int[] prices) {
            // 动态规划方法
            // 定义dp数组，dp[i][0]第i天持有股票带来的最大收益， dp[i][1]不持有股票的最大收益
            var dp = new int[prices.Length, 2];
            dp[0,0] = -prices[0];
            dp[0,1] = 0;

            for(var i = 1; i < prices.Length; i++)
            {
                dp[i, 0] = Math.Max(dp[i - 1, 0], -prices[i]);
                dp[i, 1] = Math.Max(dp[i - 1, 1], dp[i - 1, 0] + prices[i]);
            }

            return Math.Max(dp[prices.Length - 1, 0], dp[prices.Length - 1, 1]);
        }
    }
}