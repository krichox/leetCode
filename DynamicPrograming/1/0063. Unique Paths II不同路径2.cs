using System;

namespace DynamicPrograming._1
{
    /*https://leetcode.cn/problems/unique-paths-ii/*/
    public class Unique_Paths_II不同路径2 {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            var dp = new int[obstacleGrid.Length, obstacleGrid[0].Length];
            var m = obstacleGrid.Length;
            var n =  obstacleGrid[0].Length;

            for(var i = 0; i < m && obstacleGrid[i][0] == 0 ;i++)
            {
                dp[i,0] = 1;
            
            }

            for(var i = 0; i < n && obstacleGrid[0][i] == 0; i++)
            {
                dp[0,i] = 1;
            
            }

            for(var i = 1; i < m; i++)
            {
                for(var j = 1; j < n; j++)
                {
                    dp[i, j] =  obstacleGrid[i][j] == 0 ? dp[i - 1, j] + dp[i, j - 1] : 0;
                }
            }

            return dp[m - 1, n - 1];
        }
    }
}