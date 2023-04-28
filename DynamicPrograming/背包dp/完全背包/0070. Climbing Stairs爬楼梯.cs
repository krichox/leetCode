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

        public class Climbing_Stairs爬楼梯2
        {
            public int ClimbStairs(int n)
            {

                // 完全背包版本
                var dp = new int[n + 1];

                dp[0] = 1;

                // 排列问题，讲究顺序，先遍历背包, 完全背包，无限取，顺序遍历
                for (var i = 0; i <= n; i++)
                {
                    // 遍历物品
                    for (var j = 1; j <= 2; j++)
                    {
                        if (i >= j)
                        {
                            dp[i] += dp[i - j];
                        }

                    }
                }

                return dp[n];
            }
        }
    }
}