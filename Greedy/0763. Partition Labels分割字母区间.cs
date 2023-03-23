using System;
using System.Collections.Generic;

namespace Greedy
{
    /*https://leetcode.cn/problems/partition-labels/*/
    public class Partition_Labels分割字母区间 {
        public IList<int> PartitionLabels(string s) {
            var result = new List<int>();
            var mostFarLetterIndex = new int[26];
            // 每个字母出现的最远index
            for(var i = 0; i < s.Length; i++)
            {
                mostFarLetterIndex[s[i] - 'a'] = i;
            }
        
            int left = 0, right = 0;
            for(var i = 0; i < s.Length; i++)
            {
                right = Math.Max(mostFarLetterIndex[s[i] - 'a'], right);
                if(i == right)
                {
                    result.Add(right - left + 1);
                    left = i + 1;
                }
            }

            return result;
        }
    }
}