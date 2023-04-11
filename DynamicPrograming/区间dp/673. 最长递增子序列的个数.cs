using System;

namespace DynamicPrograming.区间dp
{
    public class 最长递增子序列的个数 {
        public int FindNumberOfLIS(int[] nums) {
            // 定义dp，dp[i]0-i之间的最大递增子序列有几位
            var n = nums.Length;
            var dp = new int[n];
            //这里count[i]记录了以nums[i]为结尾的字符串,最长递增子序列的个数
            var count = new int[n];
            Array.Fill(dp, 1);
            Array.Fill(count, 1);
            int max = 1;
            int ans = 0;

            for(var i = 0; i < n; i++)
            {
                // 从0枚举到i
                for(var j = 0; j < i; j++)
                {
                    if(nums[i] > nums[j])
                    {
                        if(dp[j] + 1 > dp[i])
                        {
                            count[i] = count[j];
                        }else if(dp[j] + 1 == dp[i])
                        {
                            count[i] += count[j];
                        }

                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }

                    if(dp[i] > max)
                    {
                        max = dp[i];
                    }
                }
            }

            for(var i = 0; i < n; i++)
            {
                if(dp[i] == max)
                {
                    ans += count[i];
                }
            }

            return ans;
        }
    }   
    // o(n^2)
    // o(n)
}