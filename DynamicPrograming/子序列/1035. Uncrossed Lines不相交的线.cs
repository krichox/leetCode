using System;

namespace DynamicPrograming.子序列
{
    /*https://leetcode.cn/problems/uncrossed-lines/description/*/
    public class Uncrossed_Lines不相交的线 {
        public int MaxUncrossedLines(int[] nums1, int[] nums2) {
            var dp = new int[nums1.Length + 1, nums2.Length + 1];
            var result = 0;
            for(var i = 1; i <= nums1.Length; i++)
            {
                for(var j = 1; j <= nums2.Length; j++)
                {
                    if(nums1[i - 1] == nums2[j - 1])
                    {
                        dp[i , j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }

                    result = Math.Max(result, dp[i, j]);
                }
            }

            return result;
        }
    }
}