namespace Array.螺旋矩阵;
/*剑指 Offer 29. 顺时针打印矩阵
输入一个矩阵，按照从外向里以顺时针的顺序依次打印出每一个数字。

 

示例 1：

输入：matrix = [[1,2,3],[4,5,6],[7,8,9]]
输出：[1,2,3,6,9,8,7,4,5]
示例 2：

输入：matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
输出：[1,2,3,4,8,12,11,10,9,5,6,7]*/

public class 剑指Offer29顺时针打印矩阵
{
    public int[] SpiralOrder(int[][] matrix)
    {
        if (matrix.Length == 0)
        {
            return new int[0];
        }

        var left = 0;
        var right = matrix[0].Length - 1;
        var top = 0;
        var button = matrix.Length - 1;
        var result = new int[matrix.Length * matrix[0].Length];
        var index = 0;


        while (left <= right && top <= button)
        {
            for (var i = left; i <= right; i++)
            {
                result[index++] = matrix[top][i];
            }

            top++;

            for (var i = top; i <= button; i++)
            {
                result[index++] = matrix[i][right];
            }

            right--;
            
            if (left <= right && top <= button)
            {
                for (var i = right; i >= left; i--)
                {
                    result[index++] = matrix[button][i];
                }

                button--;

                for (var i = button; i >= top; i--)
                {
                    result[index++] = matrix[i][left];
                }

                left++;
            }
        }

        return result;
    }
}