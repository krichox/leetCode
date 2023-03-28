using System;
using System.Linq;

namespace DynamicPrograming.背包dp
{
    /*https://leetcode.cn/problems/last-stone-weight-ii/description/*/
    public class Last_Stone_Weight_II_最后一块石头的重量_II {
        public int LastStoneWeightII(int[] stones) {
            // 此题转换为尽可能分为重量相近的两个石头堆
            // 定义dp数组，dp[j] 重量为j的物品最大值
            var dp = new int[15001];

            dp[0] = 0;
            var sum = stones.Sum();
            var target = stones.Sum() / 2;
            for(var i = 0; i < stones.Length; i++)
            {
                for(var j = target; j >= stones[i]; j--)
                {
                    dp[j] = Math.Max(dp[j], dp[j - stones[i]] + stones[i]);
                }
            }

            return sum - dp[target] - dp[target];
        }
    }
}