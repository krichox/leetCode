using System.Text;

namespace String {}
/*https://leetcode.cn/problems/reverse-words-in-a-string/*/

/*字符串的左旋转操作是把字符串前面的若干个字符转移到字符串的尾部。请定义一个函数实现字符串左旋转操作的功能。比如，输入字符串"abcdefg"和数字2，该函数将返回左旋转两位得到的结果"cdefgab"。

示例 1：
输入: s = "abcdefg", k = 2
输出:"cdefgab"
示例 2：

输入: s = "lrloseumgh", k = 6
输出:"umghlrlose"。*/
public class 剑指_Offer_58___II__左旋转字符串
{
    public string ReverseLeftWords直接模拟(string s, int n) {
        var sb = new StringBuilder();
        for(var i = n; i < s.Length; i++)
        {
            sb.Append(s[i]);
        }

        for(var i = 0; i < n; i++)
        {
            sb.Append(s[i]);
        }
  
        return sb.ToString();
    }
    
    public string ReverseLeftWords不开辟新空间(string s, int n) {
        var sb = new StringBuilder(s);
        // 翻转前n个
        Reverse(sb, 0, n - 1);
        // 翻转后n个
        Reverse(sb, n, s.Length - 1);
        // 翻转全部
        Reverse(sb, 0, s.Length - 1);
        return sb.ToString();
    }

    private void Reverse(StringBuilder sb, int left, int right)
    {
        while(left < right)
        {
            (sb[left], sb[right]) = (sb[right], sb[left]);
            left++;
            right--;
        }
    }
}