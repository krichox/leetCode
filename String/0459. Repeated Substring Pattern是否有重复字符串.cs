using System.Linq;

namespace String {}

public class 是否有重复字符串 {
    
/*/*https://leetcode.cn/problems/implement-strstr/*/
/*Implement strStr().
 
Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle
is not part of haystack.

Clarification:
What should we return when needle is an empty string? This is a great question to ask during an interview.
For the purpose of this problem, we will return 0 when needle is an empty string.This is consistent to C 's strstr() and Java's indexOf().

Example 1:
Input: haystack = "hello", needle = "ll"
Output: 2

Example 2:
Input: haystack = "aaaaa", needle = "bba"
Output: -1*/
    
    /*如果 next[len - 1] != -1，则说明字符串有最长相同的前后缀（就是字符串里的前缀子串和后缀子串相同的最长长度）。

最长相等前后缀的长度为：next[len - 1] + 1。(这里的next数组是以统一减一的方式计算的，因此需要+1)

数组长度为：len。

如果len % (len - (next[len - 1] + 1)) == 0 ，则说明 (数组长度-最长相等前后缀的长度) 正好可以被 数组的长度整除，说明有该字符串有重复的子字符串。

数组长度减去最长相同前后缀的长度相当于是第一个周期的长度，也就是一个周期的长度，如果这个周期可以被整除，就说明整个数组就是这个周期的循环。*/
    public class Solution {
        public bool RepeatedSubstringPattern(string s) {
            var next = GetNext(s);
            var sum = next.Sum(x => x);
            var len = next.Length;
            // next[len - 1] != -1 说明有重复, len %  (len - (next[len - 1] + 1)) == 0 数组长度 / 数组长度 - 最长前后缀== 数组周期
            if(next[len - 1] != -1 &&  len %  (len - (next[len - 1] + 1)) == 0)
            {
                return true;
            }

            return false;
        }

        private int[] GetNext(string s)
        {
            var j = -1;
            var next = new int[s.Length];
            next[0] = j;
            for(var i = 1; i < s.Length; i++)
            {
                // 不匹配回退
                while(j >= 0 && s[i] != s[j + 1])
                {
                    j = next[j];
                }
                // 匹配j+1
                if(s[i] == s[j + 1])
                {
                    j++;
                }
                next[i] = j;
            }

            return next;
        }
    }
}