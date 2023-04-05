using System;

namespace DynamicPrograming.子序列
{
    /*https://leetcode.cn/problems/delete-operation-for-two-strings/description/*/
    public class Delete_Operation_for_Two_Strings两个字符串的删除操作 {
        public int MinDistance(string word1, string word2) {
            // 定义dp数组，dp[i - 1, j - 1], word1以i-1结尾时，wrod2以j-1结尾时，最少需要删除的个数
            var m = word1.Length;
            var n = word2.Length;
            var dp = new int[m + 1, n + 1];
            for(var i = 1; i <= m; i++)
            {
                dp[i, 0] = i;
            }

            for(var i = 1; i <= n; i++)
            {
                dp[0, i] = i;
            }
            for(var i = 1; i <= m; i++)
            {
                for(var j = 1; j <= n; j++)
                {
                    if(word1[i - 1] == word2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }else
                    {
                        dp[i, j] = Math.Min(dp[i - 1, j], dp[i, j - 1]) + 1;
                    }
                }
            }

            return dp[m, n];
        }
    }
}