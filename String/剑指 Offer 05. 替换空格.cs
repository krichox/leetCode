using System.Text;

namespace String;

public class 替换空格
{
    
    // 直接模拟
    public string ReplaceSpace模拟(string s) {
        var sb = new StringBuilder();
        for(var i = 0; i < s.Length; i++)
        {
            if(s[i] == ' ')
            {
                sb.Append("%20");
            }else
            {
                sb.Append(s[i]);
            }
        }

        return sb.ToString();
    }
}