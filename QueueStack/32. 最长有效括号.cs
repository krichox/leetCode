using System;
using System.Collections.Generic;

namespace QueueStack
{
    /*https://leetcode.cn/problems/longest-valid-parentheses/description/*/
    public class 最长有效括号 {
        public int LongestValidParentheses(string s) {
            var stack = new Stack<int>();
            var n = s.Length;
            // dp[i]: [0..i -1]有效括号
            var dp = new int[n + 1];
            dp[0] = 0;
            for(var i = 1; i <= n; i++)
            {
                if(s[i - 1] == '(')
                {
                    stack.Push(i - 1);
                    dp[i] = 0;
                }

                if(s[i - 1] == ')')
                {
                    if(stack.Count != 0 && s[stack.Peek()] == '(')
                    {
                        var leftIndex = stack.Pop();
                        var len = i - leftIndex;
                        dp[i] = len + dp[leftIndex];
                    }else
                    {
                        dp[i] = 0;
                    }
                }
            }        
        
            var res = 0;
            for(var i = 0; i < dp.Length; i++)
            {
                res = Math.Max(res, dp[i]);
            }

            return res;
        
        
        }
    }
}