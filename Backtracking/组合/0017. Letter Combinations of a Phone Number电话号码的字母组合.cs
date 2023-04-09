using System.Collections.Generic;
using System.Text;

namespace Backtracking.组合
{
    /*https://leetcode.cn/problems/letter-combinations-of-a-phone-number/
     Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.
Example 1:

Input: digits = "23"
Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
Example 2:

Input: digits = ""
Output: []
Example 3:

Input: digits = "2"
Output: ["a","b","c"]*/
    public class Letter_Combinations_of_a_Phone_Number电话号码的字母组合
    {
        private Dictionary<int, string> LetterSNumberDic = new Dictionary<int,string>
        {

            {2, "abc"},
            {3, "def"},
            {4, "ghi"},
            {5, "jkl"},
            {6, "mno"},
            {7, "pqrs"},
            {8, "tuv"},
            {9, "wxyz"}
        };

        List<string> result = new List<string>();
        StringBuilder path = new StringBuilder();
        public IList<string> LetterCombinations(string digits) {

            if(digits == null || digits.Length == 0)
            {
                return result;
            }
            getLetterCombinations(digits, 0);
            return result;
        }

        void getLetterCombinations(string digits, int index)
        {
            // 终止条件
            if(index == digits.Length)
            {
                result.Add(path.ToString());
                return;
            }

            // 单层递归逻辑
            //注意减去0， 将char转换为int
            var letters = LetterSNumberDic[digits[index] - '0'];
            for(var i = 0; i < letters.Length; i ++)
            {
                path.Append(letters[i]);
                getLetterCombinations(digits, index + 1);
                path.Remove(path.Length - 1, 1);
            }

        }
    }
}