namespace HashTable;

/*https://leetcode.cn/problems/valid-anagram/*/

/*Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
Example 2:

Input: s = "rat", t = "car"
Output: false
。*/
public class Class1
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        
        var record = new int[26];
        for (var i = 0; i < s.Length; i++)
        {
            record[s[i] - 'a'] += 1;
            record[t[i] - 'a'] -= 1;
        }

        for(var i = 0; i < record.Length; i++)
        {
            if(record[i] != 0)
            {
                return false;
            }
        }

        return false;
    }
}