using System;

namespace DynamicPrograming.子序列
{
    /*https://leetcode.cn/problems/distinct-subsequences/description/*/
    public class Distinct_Subsequences不同的子序列 {
        public int NumDistinct(string s, string t) {
            // 定义dp数组, dp[i - 1, j -1], i-1,j-1时，最大公共子序列的个数
            var m = s.Length;
            var n = t.Length;
            var res = 0;
            var dp = new int[m + 1, n + 1];
            for(var i = 0; i < m; i++)
            {
                dp[i, 0] = 1;
            }

            for(var i = 1; i <= m; i++)
            {
                for(var j = 1; j <= n; j++)
                {
                    if(s[i - 1] == t[j - 1])
                    {
                        // 如果相等删除两个相同元素，或者删除s的最后一个元素进行比对
                        dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j];
                    }else
                    {
                        // 不相等，删除s[i - 1]
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }

            return dp[m, n];
        }
    
    }
}