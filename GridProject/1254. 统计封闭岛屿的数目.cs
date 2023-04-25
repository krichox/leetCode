namespace GridProject
{
    /*https://leetcode.cn/problems/number-of-closed-islands/description/*/
    public class 统计封闭岛屿的数目 {
        public int ClosedIsland(int[][] grid) {
            var n = grid.Length;
            var m = grid[0].Length;
            var res = 0;
            for(var i = 0; i < n; i++)
            {
                dfs(grid, i, 0);
                dfs(grid, i,  m - 1);
            }

            for(var i = 0; i < m; i++)
            {
                dfs(grid, 0, i);
                dfs(grid, n - 1, i);
            }

            for(var i = 0; i < n; i++)
            {
                for(var j = 0; j < m; j++)
                {
                    if(grid[i][j] == 0)
                    {
                        res++;
                        dfs(grid, i, j);
                    }
                }
            }
            return res;
        }

        void dfs(int[][] grid, int i, int j)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            if(i < 0 || i >= n || j < 0 || j >= m)
            {
                return;
            }

            if(grid[i][j] == 1)
            {
                return;
            }

            grid[i][j] = 1;

            dfs(grid, i + 1, j);
            dfs(grid, i - 1, j);
            dfs(grid, i, j - 1);
            dfs(grid, i, j + 1);
        }
    }
}