namespace DynamicPrograming._1
{
    /*https://leetcode.cn/problems/unique-paths/*/
    public class Unique_Paths不同路径 {
        public int UniquePaths(int m, int n) {
            var dp = new int[m,n];
    
            // dp[m][n] = dp[m][n - 1] + dp[m - 1][n];

    
            for(var i = 0; i < m; i++)
            {
                dp[i,0] = 1;
            }

            for(var i = 0; i < n; i++)
            {
                dp[0,i] = 1;
            }
            for(var i = 1; i < m; i++)
            {
                for(var j = 1; j < n; j++)
                {
                    dp[i,j] = dp[i,j - 1] + dp[i - 1,j];
                }
            }

            return dp[m-1,n-1];
        }
    }
}