using System;

namespace DynamicPrograming.子序列
{
    /*https://leetcode.cn/problems/edit-distance/*/
    public class Edit_Distance编辑距离 {
        public int MinDistance(string word1, string word2) {
            // 定义dp为 wrod 为i-1时，word2为j-1时，相等所需要的最小操作
            var m = word1.Length;
            var n = word2.Length;
            var dp = new int[m + 1, n + 1];

            for(var i = 0; i <= m; i++)
            {
                dp[i, 0] = i;
            }

            for(var i = 0; i <= n; i++)
            {
                dp[0, i ] = i;
            }

            for(var i = 1; i <= m; i++)
            {
                for(var j = 1; j <= n; j++)
                {
                    if(word1[i - 1] == word2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }else
                    {
                        dp[i, j] = Math.Min(dp[i - 1, j - 1] , Math.Min(dp[i - 1, j], dp[i, j - 1])) + 1;
                    }
                }
            }

            return dp[m, n];
        }
    }
}