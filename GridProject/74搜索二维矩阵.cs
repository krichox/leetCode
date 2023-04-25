namespace GridProject
{
    /*https://leetcode.cn/problems/search-a-2d-matrix/description/*/
    public class 搜索二维矩阵
    {
        // 将二维映射到一维，二分查找即可
        public bool SearchMatrix(int[][] matrix, int target) {
            var n = matrix.Length;
            var m = matrix[0].Length;
        
            var left = 0;
            var right = n * m - 1;
            while(left <= right)
            {
                var mid = left + (right - left) / 2;
                var cur = matrix[mid / m][mid % m];
                if(cur == target)
                {
                    return true;
                }
                else if(cur < target)
                {
                    left = mid + 1;
                }else
                {
                    right = mid - 1;
                }
            }

            return false;
        }
    }
}