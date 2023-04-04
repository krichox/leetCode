using System;

namespace DynamicPrograming.子序列
{
    /*https://leetcode.cn/problems/longest-common-subsequence/description/*/
    public class Longest_Common_Subsequence最长公共子序列 {
        public int LongestCommonSubsequence(string text1, string text2) {
            var dp = new int[text1.Length + 1, text2.Length + 1];
            var result = 0;
            for(var i = 1; i <= text1.Length; i++)
            {
                for(var j = 1; j <= text2.Length; j++)
                {
                    // 注意是i - 1
                    if(text1[i - 1] == text2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }else
                    {
                        // 左边少一个，或者右边少一个
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }

                    result = Math.Max(dp[i, j], result);

                }
            }

            return result;
        }
    }
}