using System.Collections.Generic;

namespace ArrayProject.螺旋矩阵
{
    /*给你一个 m 行 n 列的矩阵 matrix ，请按照 顺时针螺旋顺序 ，返回矩阵中的所有元素。

示例 1：


输入：matrix = [[1,2,3],[4,5,6],[7,8,9]]
输出：[1,2,3,6,9,8,7,4,5]
示例 2：


输入：matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
输出：[1,2,3,4,8,12,11,10,9,5,6,7]*/

    public class 旋转矩阵1
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var left = 0;
            var right = matrix[0].Length - 1;
            var top = 0;
            var button = matrix.Length - 1;
            var result = new List<int>();

            while (left <= right && top <= button)
            {
                for (var i = left; i <= right; i++)
                {
                    result.Add(matrix[top][i]);
                }

                top++;

                for (var i = top; i <= button; i++)
                {
                    result.Add(matrix[i][right]);
                }

                right--;

                if (left <= right && top <= button)
                {
                    for (var i = right; i >= left; i--)
                    {
                        result.Add(matrix[button][i]);
                    }

                    button--;


                    for (var i = button; i >= top; i--)
                    {
                        result.Add(matrix[i][left]);
                    }

                    left++;
                }
            }

            return result;
        }
        
        public IList<int> SpiralOrder2(int[][] matrix) {
            var leftBound = 0;
            var topBound = 0;
            var rightBound = matrix[0].Length - 1;
            var buttonBound = matrix.Length - 1;
            var result = new List<int>();
            while(leftBound <= rightBound && topBound <= buttonBound)
            {
                // 左到右遍历
                if(topBound <= buttonBound)
                {
                    for(var i = leftBound; i <= rightBound; i++)
                    {
                        result.Add(matrix[topBound][i]);
                    }
                    topBound++;
                }

                // 从右上到右下

                if(leftBound <= rightBound)
                {
                    for(var i = topBound; i <= buttonBound; i++)
                    {
                        result.Add(matrix[i][rightBound]);
                    }

                    rightBound--;
                }

                // 右下到左下
                if(topBound <= buttonBound)
                {
                    for(var i = rightBound; i >= leftBound; i--)
                    {
                        result.Add(matrix[buttonBound][i]);
                    }
                
                    buttonBound--;
                }

                if(leftBound <= rightBound)
                {
                    for(var i = buttonBound; i >= topBound; i--)
                    {
                        result.Add(matrix[i][leftBound]);
                    }
                    leftBound++;
                }

            }

            return result;
        }
        // O(nm) 矩阵里面的每一个元素都需要被访问一次
        // O（1） 只使用了一个result输出结果
    }
}