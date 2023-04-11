using System.Collections.Generic;
using System.Text;

namespace DynamicPrograming.区间dp
{
    /*https://leetcode.cn/problems/palindromic-substrings/description/*/
    public class Palindromic_Substrings回文子串
    {
        public int CountSubstrings(string s)
        {
            // 定义dp数组，数组区间为i,j 时，是否为回文串 

            var dp = new bool[s.Length, s.Length];
            var result = 0;
            for (var i = s.Length - 1; i >= 0; i--)
            {
                for (var j = i; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        // 只有1或者两个元素
                        if (j - i <= 1)
                        {
                            dp[i, j] = true;
                            result++;
                        }
                        else
                        {
                            dp[i, j] = dp[i + 1, j - 1];
                            if (dp[i, j])
                            {
                                result++;
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}