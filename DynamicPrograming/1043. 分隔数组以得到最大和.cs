using System;

namespace DynamicPrograming
{
    /*https://leetcode.cn/problems/partition-array-for-maximum-sum/description/*/
    public class 分隔数组以得到最大和 {
    public int MaxSumAfterPartitioning(int[] arr, int k) {
        var n = arr.Length;
        // 定义dp为0-i的分割数组最大值
        var dp = new int[n + 1];

        
        for(var i = 0; i <= n; i++)
        {
            var max = 0;
            // 枚举一点j求最大值
            for(var j = i; j > i - k && j >= 0; j--)
            {
                max = Math.Max(max, arr[j]);
                dp[i + 1] = Math.Max(dp[i + 1], dp[j] + (i - j + 1) * max);
            }
        }

        return dp[n];
    }
    }
}