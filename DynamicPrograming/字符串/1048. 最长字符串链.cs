using System;
using System.Collections.Generic;

namespace DynamicPrograming.字符串
{
    /*https://leetcode.cn/problems/longest-string-chain/description/*/
    public class 最长字符串链 {
        public int LongestStrChain(string[] words) {
            // 考虑最后一个word，枚举删除每一个单词的结果，如果枚举的单词再列表里，那么就变成了子问题
            Array.Sort(words, (a, b) => a.Length - b.Length);
            Dictionary<string, int> dic = new Dictionary<string, int>();
            var ans = 0;
            for(var i = 0; i < words.Length; i++)
            {
                var res = 0;
                for(var j = 0; j < words[i].Length; j++)
                {
                    var sub = words[i].Substring(0, j) + words[i].Substring(j + 1);
                    res = Math.Max(res, dic.GetValueOrDefault(sub, 0));
                }
                dic[words[i]] = res + 1;
                ans = Math.Max(ans, res + 1);

            }

            return ans;
        }

    }
}