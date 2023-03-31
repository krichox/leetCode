using System;

namespace DynamicPrograming.打家劫舍
{
    /*https://leetcode.cn/problems/house-robber/*/
    public class House_Robber打家劫舍 {
        public int Rob(int[] nums) {
            // 定义dp数组，dp[i]: 长度为i可以偷取的最大值

            // dp[i]偷： dp[i - 2] + nums[i]
            // dp[i]不偷，dp[i] = dp[i - 1];

            if(nums.Length == 1)
            {
                return nums[0];
            }
            var dp = new int[nums.Length];
        
            dp[0] = nums[0];
            dp[1] = Math.Max(dp[0], nums[1]);

            for(var i = 2; i < nums.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
            }

            return dp[dp.Length -1];
        }
    }
}