using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String.模拟
{
    /*https://leetcode.cn/problems/add-strings/description/*/
    public class 字符串相加 {
        public string AddStrings(string num1, string num2) {
            var index1 = num1.Length - 1;
            var index2 = num2.Length - 1;
            var carry = 0;
            var sb = new StringBuilder();
            while(index1 >= 0 || index2 >= 0 || carry > 0)
            {
                var char1 = index1 >= 0 ?  num1[index1] : '0';
                var char2 = index2 >= 0 ? num2[index2] : '0';
                var sum = (char1 - '0') + (char2 - '0') + carry;
                carry = sum / 10;
                sb.Append(sum % 10);
                index1--;
                index2--;
            }

            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}