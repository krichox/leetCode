namespace GridProject
{
    /*https://leetcode.cn/problems/count-sub-islands/description/*/
    public class 统计子岛屿 {
        public int CountSubIslands(int[][] grid1, int[][] grid2) {
            var n =  grid1.Length;
            var m = grid1[0].Length;
            var res = 0;

            for(var i = 0; i < n; i++)
            {
                for(var j = 0; j < m; j++)
                {
                    if(grid1[i][j] == 0 && grid2[i][j] == 1)
                    {
                        dfs(grid2, i, j);
                    }
                }
            }

            for(var i = 0; i < n; i++)
            {
                for(var j = 0; j < m; j++)
                {
                    if(grid2[i][j] == 1)
                    {
                   
                        res++;
                        dfs(grid2, i , j);
                    }
                }
            }
            return res;
        }

        void dfs(int[][] grid, int i, int j)
        {
            var n =  grid.Length;
            var m = grid[0].Length;
            if(i < 0 || j < 0 || i >= n || j >= m || grid[i][j] == 0)
            {
                return;
            }
        
            grid[i][j] = 0;

            dfs(grid, i + 1, j);
            dfs(grid, i - 1, j);
            dfs(grid, i, j + 1);
            dfs(grid, i, j - 1);
        }
    }
}