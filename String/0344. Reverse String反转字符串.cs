namespace String;

public class 反转字符串
{
    public void ReverseString(char[] s) {
        var left = 0;
        var right = s.Length - 1;
        while(left < right)
        {
            (s[left], s[right]) = (s[right], s[left]);
            left++;
            right--;
        }
    }
}