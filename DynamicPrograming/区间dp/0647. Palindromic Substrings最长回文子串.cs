using System.Collections.Generic;
using System.Text;

namespace DynamicPrograming.区间dp
{
    /*https://leetcode.cn/problems/palindromic-substrings/description/*/
    public class Palindromic_Substrings最长回文子串
    {
        StringBuilder path;
        List<string> result = new List<string>();
        public int CountSubstrings(string s) {
            path = new StringBuilder();
            backTracing(s, 0);
            return result.Count;
        }

        void backTracing(string s, int startIndex)
        {
            // 递归边界
            result.Add(path.ToString());
            if (path.Length == s.Length)
            {
                return;
            }
            for(var i = startIndex; i < s.Length; i++)
            {
                var subString = s.Substring(startIndex, i - startIndex + 1);
                if(isPalindromic(subString))
                {
                    path.Append(subString);
                    backTracing(s, i + 1);
                    path.Remove(path.Length - 1,1);
                }
            }
        }

        private bool isPalindromic(string s)
        {
            var left = 0;
            var right = s.Length - 1;
            while(left <= right)
            {
                if(s[left] != s[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}