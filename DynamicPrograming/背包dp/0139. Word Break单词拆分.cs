using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LinkedList;

namespace DynamicPrograming.背包dp
{
    /*https://leetcode.cn/problems/word-break/description/*/
    public class Word_Break单词拆分 {
        public bool WordBreak(string s, IList<string> wordDict) {


            // 题目转换-> 完全背包，无限取，排列

            // 定义dp数组，dp[j]: 长度为j的数组能否使用workDict拼接出来

            var dp = new bool[s.Length + 1];

            dp[0] = true;

            var set = wordDict.ToHashSet();

            //有顺序，求排列数，先背包再物品
            for(var i = 1; i <= s.Length; i++)
            {
                for(var j = 0; j < i; j++)
                {
                    var subString = s.Substring(j, i - j);
                    if(set.Contains(subString) && dp[j])
                    {
                        dp[i] = true;
                    }
                }
            }

            return dp[s.Length];

        }
    }
}