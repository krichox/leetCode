namespace DynamicPrograming.字符串
{
    /*https://leetcode.cn/problems/ba-shu-zi-fan-yi-cheng-zi-fu-chuan-lcof/description/*/
    public class 剑指_Offer_46__把数字翻译成字符串
    {
        public int TranslateNum(int num) {
            var s = num.ToString();
            var n = s.Length;
            // dp[i]: [0..i]的解码方式
            var dp = new int[n + 1];

            dp[0] = 1;
            dp[1] = 1;

            for(var i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1];

                var curNum = 10 * (s[i - 2] - '0') + (s[i - 1] - '0');
                if(curNum >= 10 && curNum <= 25)
                {
                    dp[i] += dp[i - 2];
                }
            }

            return dp[n];
        }
    }
}