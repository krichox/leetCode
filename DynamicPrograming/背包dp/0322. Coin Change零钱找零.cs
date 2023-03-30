using System;

namespace DynamicPrograming.背包dp
{
    /*https://leetcode.cn/problems/coin-change/*/
    public class Coin_Change零钱找零 {
        public int CoinChange(int[] coins, int amount) {
            // 定义dp, dp[j]：组成amount所需的最少数量
            var dp = new int[amount + 1];

            Array.Fill(dp, int.MaxValue);
            dp[0] = 0;
            // 遍历物品
            for(var i = 0; i < coins.Length; i++) 
            {
                // 完全背包问题，无限取，正向遍历,// 01问题反向遍历
                for(var j = coins[i]; j <= amount; j++)
                {
                    // 遍历物品
                    //只有dp[j-coins[i]]不是初始最大值时，该位才有选择的必要
                    if(dp[j - coins[i]] != int.MaxValue)
                    {
                        dp[j] = Math.Min(dp[j - coins[i]] + 1, dp[j]);
                    }

                }
            }

            return dp[amount] == int.MaxValue ? -1 : dp[amount];
        }
    }
}