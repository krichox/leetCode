using System;

namespace DynamicPrograming.子序列
{
    /*https://leetcode.cn/problems/maximum-subarray/description/*/
    public class Maximum_Subarray最大子数组和
    {
        public int MaxSubArray(int[] nums)
        {
            // 定义dp,dp[i]数组小标为i时，最大的子数组和
            if (nums.Length == 1)
            {
                return nums[0];
            }

            var dp = new int[nums.Length];
            dp[0] = nums[0];
            var res = dp[0];
            // 初始化

            for (var i = 1; i < nums.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 1] + nums[i], nums[i]);
                res = Math.Max(dp[i], res);
            }

            return res;
        }
    }

}