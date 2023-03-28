using System;

namespace DynamicPrograming._1
{
    /*https://leetcode.cn/problems/integer-break/description/*/
    public class Integer_Break拆分整数 {
        public int IntegerBreak(int n) {
            var dp = new int[n + 1];
        
            dp[1] = 1;
            dp[2] = 1;

            for(var i = 3; i <= n; i++)
            {
                for(var j = 1; j <= i / 2; j++)
                {
                    dp[i] = Math.Max( Math.Max(j * ( i -  j), j * dp[i - j]), dp[i]);
                }
            }

            return dp[n];
        }
    }
}