using System;

namespace GridProject
{
    /*https://leetcode.cn/problems/max-area-of-island/description/*/
    public class 岛屿的最大面积 {
        public int MaxAreaOfIsland(int[][] grid) {
            var n = grid.Length;
            var m = grid[0].Length;
        
            var res = 0;
            for(var i = 0; i < n; i++)
            {
                for(var j = 0; j < m; j++)
                {
                    if(grid[i][j] == 1)
                    {
                        res = Math.Max(res, dfs(grid, i, j));
                    }
                }
            }

            return res;

            int dfs(int[][] grid, int i, int j)
            {
                var n = grid.Length;
                var m = grid[0].Length;
                if(i < 0 || i >= n || j < 0 || j >= m || grid[i][j] == 0)
                {
                    return 0;
                }

                grid[i][j] = 0;
                return dfs(grid, i, j + 1) + dfs(grid, i, j - 1) + dfs(grid, i - 1, j) + dfs(grid, i + 1, j) + 1;
            }

        }
    }
}