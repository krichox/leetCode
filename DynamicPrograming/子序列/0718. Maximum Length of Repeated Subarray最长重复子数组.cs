using System;

namespace DynamicPrograming.子序列
{
    /*https://leetcode.cn/problems/maximum-length-of-repeated-subarray/description/*/
    public class Maximum_Length_of_Repeated_Subarray最长重复子数组 {
        public int FindLength(int[] nums1, int[] nums2) {
            // 定义dp数组 ,dp[i,j] 以i-1,j-1时，最长重复子数组的最大值
            var dp = new int[nums1.Length + 1, nums2.Length + 1];
            var result = 0;

            for(var i = 1; i < nums1.Length + 1; i++)
            {
                for(var j =  1; j < nums2.Length + 1; j++)
                {
                    if(nums1[i - 1] == nums2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                        result = Math.Max(dp[i, j], result);
                    }                            
                }
            }

            return result;
        }
        
        
        public int FindLength2(int[] nums1, int[] nums2) {
            // 定义dp数组 ,dp[i,j] 以i-1,j-1时，最长重复子数组的最大值
            var dp = new int[nums1.Length + 1];
            var result = 0;

            for(var i = 1; i < nums1.Length + 1; i++)
            {
                for(var j =  nums2.Length; j > 0; j--)
                {
                    if(nums1[i - 1] == nums2[j - 1])
                    {
                        dp[j] = dp[j - 1] + 1;

                    }else{
                        dp[j] = 0;
                    }

                    result = Math.Max(dp[j], result);                 
                }
            }

            return result;
        }
    }
}