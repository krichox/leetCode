namespace String.模拟
{
    /*https://leetcode.cn/problems/island-perimeter/description/*/
    public class 岛屿的周长 {
        public int IslandPerimeter(int[][] grid) {
            var ans = 0;
            int[][] direct = {new []{0, 1}, new[] {0,2}};
            var n = grid.Length;
            var m = grid[0].Length;
            for(var i = 0; i < n; i++)
            {
                for(var j = 0; j < m; j++)
                {
                    if(grid[i][j] == 1)
                    {
                        var circle = 4;
                        if(i - 1 >= 0 && grid[i - 1][j] == 1)
                        {
                            circle--;
                        }

                        if(j + 1 < m && grid[i][j + 1] == 1)
                        {
                            circle--;
                        }

                        if(j - 1 >= 0 && grid[i][j - 1] == 1)
                        {
                            circle--;
                        }

                        if(i + 1 < n && grid[i + 1][j] == 1)
                        {
                            circle--;
                        }

                        ans += circle;
                    }
                }
            }

            return ans;
        }
        
        // O(nm)
        // O(1)
    }
}