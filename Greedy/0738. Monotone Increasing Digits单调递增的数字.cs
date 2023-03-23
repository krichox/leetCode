

using System.Linq;

/*https://leetcode.cn/problems/monotone-increasing-digits/description/*/
namespace Greedy
{
    public class Monotone_Increasing_Digits单调递增的数字
    {
        public int MonotoneIncreasingDigits(int n)
        {
            var s = n.ToString().ToArray();
            var startNine = int.MaxValue;
            
            for (var i =  s.Length - 2; i >= 0; i--)
            {
                if (s[i] > s[i + 1])
                {
                    s[i + 1] = '9';
                    s[i]--;
                    startNine = i + 1;
                }
            }

            for(var i = startNine; i < s.Length; i++)
            {
                s[i] = '9';
            }

            return int.Parse(string.Join("", s));
        }
    }
}