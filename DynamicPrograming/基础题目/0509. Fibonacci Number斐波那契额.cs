namespace DynamicPrograming._1
{
    /*https://leetcode.cn/problems/fibonacci-number/description/*/
    public class Fibonacci_Number斐波那契额 {
        public int Fib(int n) {
            // 确定dp数组下标含义
            if(n <= 1)
            {
                return n;
            }
            var dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            for(var i = 2; i <= n; i++)
            {
                // 递推公式
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }
    }
}