using System.Text;

namespace MathProject
{
    /*https://leetcode.cn/problems/string-to-integer-atoi/description/*/
    public class 字符串转换整数__atoi_
    {
        public int MyAtoi(string s)
        {
            var n = s.Length;
            var index = 0;
            // 删除前缀空格
            while (index < s.Length && char.IsWhiteSpace(s[index]))
            {
                index++;
            }

            if (index == s.Length)
            {
                return 0;
            }

            // 记录正负号
            var sign = 1;

            if (s[index] == '-')
            {
                sign = -1;
                index++;
            }
            else if (s[index] == '+')
            {
                index++;
            }

            if (index == n)
            {
                return 0;
            }

            long res = 0;
            while (index < n && char.IsNumber(s[index]))
            {
                res = res * 10 + s[index] - '0';
                if (res > int.MaxValue)
                {
                    break;
                }

                index++;
            }

            // 如果溢出, 强转int会和真实值不同
            if ((int) res != res)
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }

            return (int) res * sign;
        }
    }
}