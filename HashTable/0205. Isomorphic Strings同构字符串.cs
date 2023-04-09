using System.Collections.Generic;

namespace HashTable
{
    /*https://leetcode.cn/problems/isomorphic-strings/*/
    // 需要双向判断
    public class somorphic_Strings同构字符串
    {
        public bool IsIsomorphic(string s, string t)
        {
            return IsIsomorphic2(s, t) && IsIsomorphic2(t, s);
        }

        bool IsIsomorphic2(string s, string t)
        {
            var dic = new Dictionary<char, char>();
            for (var i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], t[i]);
                }
                else
                {
                    if (dic[s[i]] != t[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}