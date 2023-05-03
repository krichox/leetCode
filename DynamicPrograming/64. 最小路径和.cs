using System;

namespace DynamicPrograming
{
    /*https://leetcode.cn/problems/minimum-path-sum/description/*/
    public class 最小路径和 {
        // 主要处理边界问题
        public int MinPathSum(int[][] grid) {
            var n = grid.Length;
            var m = grid[0].Length;

            for(var i = 1; i < n; i++)
            {
                grid[i][0] = grid[i][0] + grid[i - 1][0]; 
            }

            for(var j = 1; j < m; j++)
            {
                grid[0][ j] = grid[0][j] + grid[0][j - 1];
            }

            for(var i = 1; i < n; i++)
            {
                for(var j = 1; j < m; j++)
                {
                    grid[i][ j] = Math.Min(grid[i - 1][ j], grid[i][ j - 1]) + grid[i][j];                
                }
            }

            return grid[n - 1][ m - 1];
        }
    
    }
}