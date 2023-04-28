using System;

namespace DynamicPrograming
{
    /*https://leetcode.cn/problems/maximum-product-subarray/description/*/
    public class 乘积最大的子数组 {
        public int MaxProduct(int[] nums) {
            var dp1 = new int[nums.Length];
            var dp2 = new int[nums.Length];
            if(nums.Length == 1)
            {
                return nums[0];
            }
            dp1[0] = nums[0];
            dp2[0] = nums[0];
            var max = int.MinValue;

            for(var i = 1; i < nums.Length; i++)
            {
                dp1[i] = Math.Max(dp1[i - 1] * nums[i], Math.Max(nums[i], dp2[i - 1] * nums[i]));
                dp2[i] = Math.Min(dp2[i - 1] * nums[i], Math.Min(nums[i], dp1[i - 1] * nums[i]));
            }

            for(var i = 0; i < dp1.Length; i++)
            {
                max = Math.Max(max, dp1[i]);
            }

            return max;
        }
    }
}