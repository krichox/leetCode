namespace GridProject
{
    /*https://leetcode.cn/problems/search-a-2d-matrix-ii/description/*/
    public class 搜索二维矩阵_II {
        public bool SearchMatrix(int[][] matrix, int target) {
            //  z字形查找
            var n = matrix.Length;
            var m = matrix[0].Length;
            var x = 0;
            var y = m - 1;
            while(x < n && y >= 0)
            {
                if(matrix[x][y] == target)
                {
                    return true;
                }
                else if(matrix[x][y] < target)
                {
                    x++;
                }
                else
                {
                    y--;
                }
            }

            return false;
        }
    }
}