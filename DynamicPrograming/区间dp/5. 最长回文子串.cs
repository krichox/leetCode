namespace DynamicPrograming.子序列
{
    /*https://leetcode.cn/problems/longest-palindromic-substring/description/*/
    public class 最长回文子串 {
        public string LongestPalindrome(string s) {
            var n = s.Length;
            int left = 0; 
            int right = 0;
            int maxLen = 0;
            //  数组下标为i，j时，最长回文串
            var dp = new bool[n, n];

            for(var i = n - 1; i >= 0; i--)
            {
                for(var j = i; j < n; j++)
                {
                    if(s[i] == s[j])
                    {
                        if(j - i <= 1)
                        {
                            dp[i, j] = true;
                        }
                        else
                        {
                            dp[i, j] = dp[i + 1, j - 1];
                        }
                
                    }

                    if(dp[i, j] &&  j - i > maxLen)
                    {
                        left = i;
                        right = j;
                        maxLen = j - i;
                    }
                }
            }


            return s.Substring(left, right - left + 1);
        }
        
        // o(n^2)
        // o(n^2)
    }
}