namespace DynamicPrograming.背包dp
{
    /*https://leetcode.cn/problems/coin-change-ii/*/
    public class Coin_Change_II零钱兑换_II {
        public int Change(int amount, int[] coins) {
            // 凑成总金额j的货币组合数为dp[j]
            var dp = new int[amount + 1];
        
            // 初始化dp, 组成0
            dp[0] = 1;
        
            // 由于求解为组合，先遍历物品，再遍历背包
            // 遍历物品
            for(var i = 0; i < coins.Length; i++)
            {
                // 由于物品无限取，顺序遍历
                for(var j = coins[i]; j <= amount; j++)
                {
                    dp[j] += dp[j - coins[i]];
                }

            }

            return dp[amount];
        }
    }
}