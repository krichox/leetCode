using System;

namespace Greedy
{
    /*https://leetcode.cn/problems/maximum-subarray/description/
     Given an integer array nums, find the 
subarray
 with the largest sum, and return its sum.

 

Example 1:

Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: The subarray [4,-1,2,1] has the largest sum 6.
Example 2:

Input: nums = [1]
Output: 1
Explanation: The subarray [1] has the largest sum 1.
Example 3:

Input: nums = [5,4,-1,7,8]
Output: 23
Explanation: The subarray [5,4,-1,7,8] has the largest sum 23.
 */
    public class Maximum_Subarray最大子数组和 {
        public int MaxSubArray(int[] nums) {
            // 暴力解法
            var max = int.MinValue;
            var sequeceValue = 0;
            // 连续和为负数时，直接赋值为0，将下一个位置作为起点继续计算
            for(var i = 0; i < nums.Length; i++)
            {
                sequeceValue += nums[i];


                if(sequeceValue > max)
                {
                    max = sequeceValue;
                }

                      
                if(sequeceValue < 0)
                {
                    sequeceValue = 0;
                }
            }

            return max;
        }
        
        public int MaxSubArray2(int[] nums)
        {
            // 动态规划方法
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