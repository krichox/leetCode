namespace GridProject
{
    /*https://leetcode.cn/problems/number-of-islands/description/*/
    public class 岛屿数量 {
        public int NumIslands(char[][] grid) {
            var res = 0;
            var n = grid.Length;
            var m = grid[0].Length;

            for(var i = 0; i < n; i++)
            {
                for(var j = 0; j < m; j++)
                {
                    if(grid[i][j] == '1')
                    {
                        res++;
                        dfs(grid, i, j);
                    }
                }
            }

            return res;
        }

        void dfs(char[][] grid, int i, int j)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            if(i >= n || i < 0 || j >= m || j < 0)
            {
                return;
            }
            if(grid[i][j] == '0')
            {
                return;
            }

            grid[i][j] = '0';

            dfs(grid, i + 1, j);
            dfs(grid, i - 1, j);
            dfs(grid, i, j + 1);
            dfs(grid, i, j - 1);
        }
    }
}