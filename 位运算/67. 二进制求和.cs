using System.Linq;
using System.Text;

namespace OtherProject
{
    /*https://leetcode.cn/problems/add-binary/*/
    public class 二进制求和 {
        public string AddBinary(string a, string b) {
            var index1 = a.Length - 1;
            var index2 = b.Length - 1;
            var carry = 0;
            var sb = new StringBuilder();
            while(index1 >= 0  || index2 >= 0 || carry > 0)
            {
                var sum = carry;
        
                if(index1 >= 0)
                {
                    sum += a[index1] - '0';
                }

                if(index2 >= 0)
                {
                    sum+= b[index2] - '0';
                }

                carry = sum / 2;
                var cur = sum % 2;
                sb.Append(cur + "");
                index1--;
                index2--;
            }

            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}