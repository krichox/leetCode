using System.Collections.Generic;

namespace HashTable
{
    /*https://leetcode.cn/problems/ransom-note/*/

/*Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true
*/

    public class 赎金信 {
        public bool CanConstruct(string ransomNote, string magazine) {
            var arr = new int[26];
            for(var i = 0; i < magazine.Length; i++)
            {
                arr[magazine[i] - 'a']++;
            }

            var a = new List<List<int>>();
            for(var i = 0; i < ransomNote.Length; i++)
            {
                arr[ransomNote[i] - 'a']--;
                if(arr[ransomNote[i] - 'a'] < 0)
                {
                    return false;
                }
            }
        
            return true;
        }
    }
}