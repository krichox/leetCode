using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicPrograming.打家劫舍
{
    /*https://leetcode.cn/problems/house-robber-ii/*/
    public class House_Robber_II打家劫舍2
    {
        public int Rob(int[] nums) {
            // 环形问题，可以拆分为Max([1:], [0, n-1])
            return Math.Max(Rob2(nums, 0, nums.Length - 2), Rob2(nums, 1, nums.Length - 1));
        }

        int Rob2(int[] nums, int start, int end)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            if(nums.Length == 1)
            {
                return nums[0];
            }
            
            if(start == end)
            {
                return nums[start];
            }

            // 定义dp数组为i时，能够偷取的最大值, 考虑下标0
            var dp = new int[nums.Length];

            dp[start] = nums[start];
            dp[start + 1] = Math.Max(dp[start], nums[start + 1]);

            for (var i = start + 2; i <= end ; i++)
            {
                dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
            }

            return dp[end];
        }
    }
}