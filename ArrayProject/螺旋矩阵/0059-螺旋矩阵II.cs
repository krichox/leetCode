namespace ArrayProject.螺旋矩阵
{
    /*给你一个正整数 n ，生成一个包含 1 到 n2 所有元素，且元素按顺时针顺序螺旋排列的 n x n 正方形矩阵 matrix 。

示例 1：
输入：n = 3
输出：[[1,2,3],[8,9,4],[7,6,5]]
示例 2：

输入：n = 1
输出：[[1]]
提示：

1 <= n <= 20
Related Topics
数组
矩阵
模拟*/

    public class 螺旋矩阵
    {
        public int[][] GenerateMatrix(int n)
        {
            var left = 0;
            var right = n - 1;
            var top = 0;
            var button = n - 1;
            var result = new int[n][];
            var num = 0;
            for (var i = 0; i < n; i++)
            {
                result[i] = new int[n];
            }

            while (num < (n * n))
            {
                for (var i = left; i <= right; i++)
                {
                    result[top][i] = ++num;
                }

                top++;

                for (var i = top; i <= button; i++)
                {
                    result[i][right] = ++num;
                }

                right--;

                for (var i = right; i >= left; i--)
                {
                    result[button][i] = ++num;
                }

                button--;

                for (var i = button; i >= top; i--)
                {
                    result[i][left] = ++num;
                }

                left++;
            }

            return result;
        }
    }
}