using System;

namespace DynamicPrograming.子序列
{
    /*https://leetcode.cn/problems/longest-increasing-subsequence/description/*/
    public class Longest_Increasing_Subsequence最长递增子序列 {
        public int LengthOfLIS(int[] nums) {
            // 定义dp数组,dp[i]: 以i结尾的最长递增子序列最大值
            var dp = new int[nums.Length];
            Array.Fill(dp, 1);

            for(var i = 1; i < nums.Length; i++)
            {
                for(var j = 0; j < i; j++)
                {
                    if(nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }

            var res = 0;

            for(var i = 0; i < dp.Length; i++)
            {
                res = Math.Max(res, dp[i]);
            }

            return res;
        }
    }
}