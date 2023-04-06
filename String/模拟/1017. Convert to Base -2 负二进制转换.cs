using System;
using System.Linq;
using System.Text;

namespace String.模拟
{
    /*https://leetcode.cn/problems/convert-to-base-2/description/*/
    public class Convert_to_Base__2_负二进制转换 {
        public string BaseNeg2(int n) {
            // 模拟
            if(n == 0)
            {
                return "0";
            }
            // 用于奇偶变换
            var k = 1;
            var sb = new StringBuilder();
            while(n != 0)
            {
                // 如果n是奇数
                if(n % 2 != 0)
                {
                    sb.Append("1");
                    n -= k;
                }
                // 偶数
                else
                {
                    sb.Append("0");
                }

                k *= -1;
                n /= 2;
            }

            var charArray = sb.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}