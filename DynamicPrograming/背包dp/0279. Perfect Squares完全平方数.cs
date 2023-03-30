using System;

namespace DynamicPrograming.背包dp
{
    /*https://leetcode.cn/problems/perfect-squares/description/*/
    public class Perfect_Squares完全平方数 {
        public int NumSquares(int n) {

            //dp: dp[j] 和为j的数凑成最小完全平方数
        
            var dp = new int[n + 1];

            Array.Fill(dp, int.MaxValue);
            dp[0] = 0;
        
            // 遍历物品
            for(var i = 1; i * i <= n; i++)
            {
                // 完全背包，顺序遍历
                // 遍历背包
                for(var j = i * i ; j <= n; j++)
                {
                    if(dp[j - i * i] != int.MaxValue)
                    {
                        dp[j] = Math.Min(dp[j - i * i] + 1, dp[j]);
                    }

                }
            }

            return dp[n];
        }
    }
}