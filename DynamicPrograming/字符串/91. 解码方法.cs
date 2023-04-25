namespace DynamicPrograming.字符串
{
    /*https://leetcode.cn/problems/decode-ways/description/*/
    public class 解码方法 {
        public int NumDecodings(string s) {
            // dp[i]:以i-1结尾的s，有多少个解码发放
            var n = s.Length;
            if(n == 0)
            {
                return 0;
            }
            var dp = new int[n + 1];

            dp[0] = 1;
            dp[1] = s[0] == '0' ? 0 : 1;
            if(s[0] == '0')
            {
                return 0;
            }
            
            for(var i = 2; i <= n; i++)
            {
                if(s[i - 1] != '0')
                {
                    dp[i] = dp[i - 1];
                }
    
                var num = 10 * (s[i - 2] - '0') + (s[i - 1] - '0');
                if(num >= 10 && num <= 26)
                {
                    dp[i] += dp[i - 2];
                }
            }

            return dp[n];
        }
    }
}