using System;
using System.Text;

namespace String
{
    /*https://leetcode.cn/problems/reverse-words-in-a-string/*/

/*Given an input string s, reverse the order of the words.

A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.

Return a string of the words in reverse order concatenated by a single space.

Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.


Example 1:
Input: s = "the sky is blue"
Output: "blue is sky the"

Example 2:
Input: s = "  hello world  "
Output: "world hello"
Explanation: Your reversed string should not contain leading or trailing spaces.
Example 3:

Input: s = "a good   example"
Output: "example good a"
Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.
*/

    public class 反转字符串里的单词 {
        public string ReverseWords(string s) {
            // 去除空格
            var sb = TrimSpaces(s);
        
            // 反转所有字符串
            Reverse(sb, 0, sb.Length - 1);
        
            //反转每个单词
            ReverseEachWords(sb);

            return sb.ToString();
        }

        private StringBuilder TrimSpaces(string s)
        {
            var left = 0;
            var right = s.Length - 1;
            // 去掉字符串开头的空白字符
            while(left <= right && s[left] == ' ')
            {
                left++;
            }
            // 去掉结尾字符串

            while(left <= right && s[right] == ' ')
            {
                right--;
            }

            var sb = new StringBuilder();
            while(left <= right)
            {
                var c = s[left];
                if(c != ' ')
                {
                    sb.Append(c);   
                }else if(sb[sb.Length - 1] != ' ')
                {
                    sb.Append(c);
                }

                sb.Remove(sb.Length - 1, 1);

                left++;
            }

            return sb;
        }

        private void Reverse(StringBuilder sb, int left, int right)
        {
            while(left < right)
            {
                (sb[left], sb[right]) = (sb[right], sb[left]);
                left++;
                right--;
            }
        }

        private void ReverseEachWords(StringBuilder sb)
        {
            int len = sb.Length;
            var start = 0;
            var end = 0;
            // 从头遍历到尾
            while(start < len)
            {
                while(end < len && sb[end] != ' ')
                {
                    end++;
                }

                Reverse(sb, start, end - 1);
                start = end + 1;
                end++;
            }
        }
        
        public string ReverseWords2(string s) {
            // 移除开头和结尾空格
            var sb = TrimSpace(s);

            ReverString(sb, 0, sb.Length - 1);

            ReverseEachWord(sb);

            return sb.ToString();

        }

        private  StringBuilder TrimSpace(string s)
        {
            var sb = new StringBuilder();
            var left = 0;
            var right = s.Length - 1;
            // 去掉开头和结尾的空格
            while(left <= right && char.IsWhiteSpace(s[left]))
            {
                left++;
            }

            while(left <= right && char.IsWhiteSpace(s[right]))
            {
                right--;
            }

            // 去除单词间空格
            for(var i = left; i <= right; i++)
            {
                if(!char.IsWhiteSpace(s[i]))
                {
                    sb.Append(s[i]);
                }else if(!char.IsWhiteSpace(sb[^1]))
                {
                    sb.Append(s[i]);
                }
            }

            return sb;
        }

        private void ReverString(StringBuilder sb, int left, int right)
        {
            while(left <= right)
            {
                var temp = sb[left];
                sb[left] = sb[right];
                sb[right] = temp;
                left++;
                right--;
            }
        }

        private void ReverseEachWord(StringBuilder sb)
        {
            var start = 0;
            for(var i = 0; i < sb.Length; i++)
            {
                if(!char.IsWhiteSpace(sb[i]))
                {
                    if(i == sb.Length - 1)
                    {
                        ReverString(sb, start, i);
                    }
                }
                else
                {
                    ReverString(sb, start, i - 1);
                    start = i + 1;
                }
            }
        }
    }
}