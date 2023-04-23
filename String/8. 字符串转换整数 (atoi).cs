using System.Text;

namespace String
{
    /*https://leetcode.cn/problems/string-to-integer-atoi/*/
    public class 字符串转换整数__atoi_ {
    public int MyAtoi(string s) {
        var sb = new StringBuilder();
        var index = 0;
        // 删除前缀空格
        while(index < s.Length && char.IsWhiteSpace(s[index]))
        {
            index++;
        }

        if(index == s.Length)
        {
            return 0;
        }

        for(var i = index; i < s.Length; i++)
        {
            if(s[i] == '-' || s[i] == '+')
            {
                sb.Append(s[i]);
                while(i + 1 < s.Length && char.IsNumber(s[i + 1]))
                {
                    sb.Append(s[i + 1]);
                    i++;
                }
                break;
            }else if (char.IsNumber(s[i]))
            {
                while(i < s.Length && char.IsNumber(s[i]))
                {
                    sb.Append(s[i]);
                    i++;
                }

                break;
            }
        }

        var result = int.Parse(sb.ToString());

        return result;

    }
    }
}