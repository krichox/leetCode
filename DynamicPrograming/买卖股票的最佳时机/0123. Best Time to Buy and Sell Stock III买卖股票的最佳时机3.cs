using System;

namespace DynamicPrograming.买卖股票的最佳时机
{
    public class Best_Time_to_Buy_and_Sell_Stock_III买卖股票的最佳时机3 {
        public int MaxProfit(int[] prices) {
            //  dp数组
            // dp[i][0] 第i天，不操作的最大利润
            // dp[i][1] 第i天，第一次持有的最大利润
            // dp[i][2] 第i天，第一次不持有的最大利润
            // dp[i][3] 第i天，第二次持有的最大利润
            // dp[i][4] 第i天，第二次不持有的最大利润  
            var dp = new int[prices.Length, 5];
            dp[0, 0] = 0;
            dp[0, 1] = -prices[0];
            dp[0, 2] = 0;
            dp[0, 3] = -prices[0];
            dp[0, 4] = 0;

            for(var i = 1; i < prices.Length; i++)
            {
                dp[i, 0] = dp[i - 1, 0];
                dp[i, 1] = Math.Max(dp[i - 1, 1], dp[i, 0] - prices[i]);
                dp[i, 2] = Math.Max(dp[i - 1, 2], dp[i - 1, 1] + prices[i]);
                dp[i, 3] = Math.Max(dp[i - 1, 3], dp[i - 1, 2] - prices[i]);
                dp[i, 4] = Math.Max(dp[i - 1, 4], dp[i - 1, 3] + prices[i]);
            }

            return dp[prices.Length - 1,4];
        }
        
        public int MaxProfit2(int[] prices) {
            
            // 压缩状态版本
            //  dp数组
            // dp[i][0] 第i天，不操作的最大利润
            // dp[i][1] 第i天，第一次持有的最大利润
            // dp[i][2] 第i天，第一次不持有的最大利润
            // dp[i][3] 第i天，第二次持有的最大利润
            // dp[i][4] 第i天，第二次不持有的最大利润  
            if(prices.Length == 1)
            {
                return 0;
            }
            var dp = new int[5];
            dp[1] = -prices[0];
            dp[3] = -prices[0];

            for(var i = 1; i < prices.Length; i++)
            {
                dp[1] = Math.Max(dp[1], dp[0] - prices[i]);
                dp[2] = Math.Max(dp[2], dp[1] + prices[i]);
                dp[3] = Math.Max(dp[3], dp[2] - prices[i]);
                dp[4] = Math.Max(dp[4], dp[3] + prices[i]);
            }

            return dp[4];
        }
    }
}