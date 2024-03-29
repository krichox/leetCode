﻿using System;
using System.Linq;

namespace DynamicPrograming.背包dp
{
    /*https://leetcode.cn/problems/target-sum/description/*/
    /*https://github.com/youngyangyang04/leetcode-master/blob/master/problems/0494.%E7%9B%AE%E6%A0%87%E5%92%8C.md*/
    public class Target_Sum目标和 {
        public int FindTargetSumWays(int[] nums, int target) {
            // 题目分析，0-1背包，求组合数dp[j] += dp[j - nums[i]];
            // left：正数的总和
            // right：负数的部分
            // right = sum - left
            // left - right = target
            // left - (sum - left ) = target
            // left = (target + sum ) / 2
            var sum = nums.Sum();
            var bagSize = (sum + target) / 2;

            if(Math.Abs(target) > sum)
            {
                return 0;
            }

            if((sum + target) % 2 == 1)
            {
                return 0;
            }
            var dp = new int[bagSize + 1];
        
            dp[0] = 1;
        

            for(var i = 0; i < nums.Length; i++)
            {
                for(var j = bagSize; j >= nums[i]; j--)
                {
                    dp[j] += dp[j - nums[i]];
                }
            }

            return dp[bagSize];
        
        }
    }
}