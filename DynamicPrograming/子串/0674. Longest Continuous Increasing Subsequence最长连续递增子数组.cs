using System;

namespace DynamicPrograming.子序列
{
    /*https://leetcode.cn/problems/longest-continuous-increasing-subsequence/description/*/
    public class Longest_Continuous_Increasing_Subsequence最长连续递增子序列 {
        public int FindLengthOfLCIS(int[] nums) {
            // 定义dp[i]以i结尾最长连续子序列
            var dp = new int[nums.Length];

            Array.Fill(dp, 1);

            var max = 1;
            for(var i = 1; i < nums.Length; i++)
            {
                if(nums[i]> nums[i - 1])
                {
                    dp[i] = Math.Max(dp[i], dp[i - 1] + 1);
                    max = Math.Max(max, dp[i]);
                }

            }
        
            return max;

        }
    }
}