namespace String
{
    /*https://leetcode.cn/problems/implement-strstr/*/
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

    public class 实现strStr
    {
        public int StrStr暴力算法(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            for (var i = 0; i < haystack.Length; i++)
            {
                var needlePer = 0;
                if (haystack[i] == needle[needlePer])
                {
                    var haystackPer = i;
                    if (haystack.Length - haystackPer < needle.Length)
                    {
                        return -1;
                    }

                    while (needlePer < needle.Length && haystack[haystackPer] == needle[needlePer])
                    {
                        needlePer++;
                        haystackPer++;
                    }

                    if (needlePer == needle.Length)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }


        // next 数组考虑的是除当前字符外的最长相同前缀后缀
        /*“KMP的算法流程：

假设现在文本串S匹配到 i 位置，模式串P匹配到 j 位置
如果j = -1，或者当前字符匹配成功（即S[i] == P[j]），都令i++，j++，继续匹配下一个字符；
如果j != -1，且当前字符匹配失败（即S[i] != P[j]），则令 i 不变，j = next[j]。此举意味着失配时，模式串P相对于文本串S向右移动了j - next [j] 位。”
    我们发现如果某个字符匹配成功，模式串首字符的位置保持不动，仅仅是i++、j++；如果匹配失配，i 不变（即 i 不回溯），模式串会跳过匹配过的next [j]个字符。整个算法最坏的情况是，当模式串首字符位于i - j的位置时才匹配成功，算法结束。
    所以，如果文本串的长度为n，模式串的长度为m，那么匹配过程的时间复杂度为O(n)，算上计算next的O(m)时间，KMP的整体时间复杂度为O(m + n)。
*/


        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
            {
                return 0;
            }

            var next = GetNext(needle);
            var j = -1;
            for (var i = 0; i < haystack.Length; i++)
            {
                // 不匹配时，回退到next[j]
                while (j >= 0 && haystack[i] != needle[j + 1])
                {
                    // 移动指针j
                    j = next[j];
                }
            
                // 匹配继续向后
                if (haystack[i] == needle[j + 1])
                {
                    j++;
                }

                // 长度匹配到匹配串到长度
                if (j == needle.Length - 1)
                {
                    return (i - needle.Length + 1);
                }
            }

            return -1;
        }

        public int[] GetNext(string s)
        {
            var next = new int[s.Length];
            var j = -1;
            next[0] = j;
            for (var i = 1; i < s.Length; i++)
            {
                while (j >= 0 && s[i] != s[j + 1])
                {
                    j = next[j];
                }

                if (s[i] == s[j + 1])
                {
                    j++;
                }

                next[i] = j;
            }

            return next;
        }
    }
}