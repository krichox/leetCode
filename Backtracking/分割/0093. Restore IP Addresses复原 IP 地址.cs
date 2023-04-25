using System.Collections.Generic;

namespace Backtracking.分割
{
    /*https://leetcode.cn/problems/restore-ip-addresses/
     A valid IP address consists of exactly four integers separated by single dots. Each integer is between 0 and 255 (inclusive) and cannot have leading zeros.

For example, "0.1.2.201" and "192.168.1.1" are valid IP addresses, but "0.011.255.245", "192.168.1.312" and "192.168@1.1" are invalid IP addresses.
Given a string s containing only digits, return all possible valid IP addresses that can be formed by inserting dots into s. You are not allowed to reorder or remove any digits in s. You may return the valid IP addresses in any order.

 

Example 1:

Input: s = "25525511135"
Output: ["255.255.11.135","255.255.111.35"]
Example 2:

Input: s = "0000"
Output: ["0.0.0.0"]
Example 3:

Input: s = "101023"
Output: ["1.0.10.23","1.0.102.3","10.1.0.23","10.10.2.3","101.0.2.3"]*/
    public class Restore_IP_Addresses复原_IP_地址
    {
        List<string> path = new List<string>();
        IList<string> result = new List<string>();

        public IList<string> RestoreIpAddresses(string s)
        {
            if (s.Length > 12)
            {
                return new List<string>();
            }

            BackTracing(s, 0);
            return result;
        }

        void BackTracing(string s, int startIndex)
        {
            // end condition
            if (startIndex >= s.Length)
            {
                if (path.Count == 4)
                {
                    var temp = string.Join(".", path.ToArray());
                    result.Add(temp);
                }

                return;
            }


            for (var i = startIndex; i < s.Length; i++)
            {
                var str = s.Substring(startIndex, i - startIndex + 1);
                if (IsStartWithZeroAndLess255(str))
                {
                    path.Add(str);
                    BackTracing(s, i + 1);
                    path.RemoveAt(path.Count - 1);
                }
            }
        }

        bool IsStartWithZeroAndLess255(string s)
        {
            if (s.StartsWith("0") && s.Length > 1)
            {
                return false;
            }

            var res = long.Parse(s);
            if (res > 255)
            {
                return false;
            }

            return true;
        }
    }
}