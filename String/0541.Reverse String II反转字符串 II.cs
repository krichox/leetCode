using System.Text;

namespace String {}

public class 反转字符串二 {
    // 直接模拟
    public string ReverseStr(string s, int k) {
        var arr = s.ToCharArray();
        var len = arr.Length;
        for(var i = 0; i < len; i+= 2 * k)
        {
            // Math.min如果
            SwitchStr(arr, i, Math.Min(i + k, len));
        }
               
        return string.Concat(arr);
        // return new string(arr);
    }

    private void SwitchStr(char[] arr, int left, int right)
    {
        right -= 1;
        while(left < right)
        {
            (arr[left], arr[right]) = (arr[right], arr[left]);
            left++;
            right--;
        }
        
    }
}