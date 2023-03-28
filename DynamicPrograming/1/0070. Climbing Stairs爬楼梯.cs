namespace DynamicPrograming._1
{
    /*https://leetcode.cn/problems/climbing-stairs/description/*/
    public class Climbing_Stairs爬楼梯 {
        public int ClimbStairs(int n) {
            var dp = new int[n + 1];
        
            if(n <= 3)
            {
                return n;
            }

            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 2;
            for(var i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }
    }
}