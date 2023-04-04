using System;

namespace DynamicPrograming.子序列
{
    public class Is_Subsequence是否是子序列 {
        public bool IsSubsequence(string s, string t) {
             // 双指针
            var left = 0;
            var right = 0;
            if(s.Length == 0)
            {
                return true;
            }

            while(left < s.Length && right < t.Length)
            {
                if(s[left] == t[right])
                {
                    left++;
                    right++;
                }else
                {
                    right++;
                }


            }

            return left == s.Length;
        }  
        
        
        public bool IsSubsequence2(string s, string t) {
            // 动态规划
            // 定义dp数组, dp[i - 1][j - 1], 为i-1, j-1时，相同的字符串有多少个
            if(s.Length == 0)
            {
                return true;
            }
            var dp = new int[s.Length + 1, t.Length + 1];
            var res = 0;
            for(var i = 1; i <= s.Length; i++)
            {
                for(var j = 1; j <= t.Length; j++)
                {
                    if(s[i - 1] == t[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                    res = Math.Max(res, dp[i, j]);
                
                }
            }

            return res == s.Length;
        }  
        
    }
}