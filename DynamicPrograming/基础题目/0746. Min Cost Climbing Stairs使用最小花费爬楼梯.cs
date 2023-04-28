using System;

namespace DynamicPrograming._1
{
    /*https://leetcode.cn/problems/min-cost-climbing-stairs/*/
    public class Min_Cost_Climbing_Stairs使用最小花费爬楼梯 {
        public int MinCostClimbingStairs(int[] cost) {
            // 1.定义dp数组含义dp[i]：到达i最少花费值
            var dp = new int[cost.Length + 1];
            // 2.递推公式
            // dp[i] = Min(dp[i - 1] + cost[i - 1], dp[i - 2] + cost[i - 2])

            // 3.初始化dp
            dp[0] = 0;
            dp[1] = 0;
            // 4.遍历顺序
            for(var i = 2; i <= cost.Length; i++)
            {
                dp[i] = Math.Min(dp[i - 1] + cost[i - 1], dp[i - 2] + cost[i - 2]);
            }
            // 5.打印dp

            return dp[cost.Length];
        }
    }
}