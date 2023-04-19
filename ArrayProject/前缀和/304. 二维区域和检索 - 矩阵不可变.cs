namespace ArrayProject.前缀和
{
    /*https://leetcode.cn/problems/range-sum-query-2d-immutable/description/*/
    public class 二维区域和检索___矩阵不可变 {
    
        // 二维前缀和
        private int[][] preSum;
        public 二维区域和检索___矩阵不可变(int[][] matrix) {
            int n = matrix.Length;
            int m = matrix[0].Length;
            preSum = new int[n + 1][];
            for(var i = 0; i < n + 1; i++)
            {
                preSum[i] = new int[m + 1];
            }
            for(var i = 0; i < n; i++)
            {
                for(var j = 0; j < m; j++)
                {
                    preSum[i + 1][j + 1] = preSum[i][j + 1] + preSum[i + 1][j] + matrix[i][j] - preSum[i][j];
                }
            }
        }
    
        public int SumRegion(int row1, int col1, int row2, int col2) {
            return preSum[row2 + 1][col2 + 1] - preSum[row1][col2 + 1] - preSum[row2 + 1][col1] + preSum[row1][col1];
        }
    }
}