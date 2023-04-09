using System.Collections.Generic;

namespace Backtracking.分割
{
    /*Given a string s, partition s such that every 
substring
 of the partition is a 
palindrome
. Return all possible palindrome partitioning of s.

 

Example 1:

Input: s = "aab"
Output: [["a","a","b"],["aa","b"]]
Example 2:

Input: s = "a"
Output: [["a"]]
*/
    public class Palindrome_Partitioning分割回文串 {
        IList<string> path = new List<string>();
        IList<IList<string>> result = new List<IList<string>>();
        public IList<IList<string>> Partition(string s) {
            BackTracing(s, 0);
            return result;
        }

        void BackTracing(string s, int startIndex)
        {
            // end condition
            if(startIndex >= s.Length)
            {
                result.Add(new List<string>(path));
                return;
            }

            for(var i = startIndex; i < s.Length; i ++)
            {
                // 获取截取字符串s
                // 字串区间为[startIndex, i];
                if(IsPalindrome(s, startIndex, i))
                {
                    var subStr = s.Substring(startIndex, i - startIndex + 1);
                    path.Add(subStr);
                }
                else
                {
                    continue;
                }

                BackTracing(s, i + 1);
                path.RemoveAt(path.Count - 1);
            }

        }

        bool IsPalindrome(string str, int left, int right)
        {
            while(left <= right)
            {
                if(str[left] != str[right])
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