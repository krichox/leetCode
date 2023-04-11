using System;

namespace DynamicPrograming.区间dp
{
    public class 分割回文串_II {
        public int MinCut(string s) {
            // 预处理
            var n = s.Length;
            var isPalindrome = new bool[n, n];

            for(var i = n - 1; i >= 0; i--)
            {
                for(var j = i; j < n; j++)
                {
                    if(s[i] == s[j])
                    {
                        if(j - i <= 1 || isPalindrome[i + 1, j - 1])
                        {
                            isPalindrome[i, j] = true;
                        }
                    }
                }
            }

            // 定义dp数组，dp[i]， 0-i时，最小的分割次数
            var dp = new int[n];
            for(var i = 0; i < n; i++)
            {
                dp[i] = i;
            }

            // dp[i] = dp[j] + 1; 枚举左端点j， 如果j到i是回文，则dp[i] = dp[j] + 1;

            for(var i = 1; i < n; i++)
            {
                if(isPalindrome[0, i])
                {
                    dp[i] = 0;
                }else
                {
                    for(var j = 1; j <= i; j++)
                    {
                        if(isPalindrome[j, i])
                        {
                            dp[i] = Math.Min(dp[i], dp[j - 1] + 1);
                        }
                    }
                }
            }

            return dp[n - 1];
        }

        // 时间复杂度：0(n ^ 2)
        // 空间复杂度：o(n ^ 2)
}