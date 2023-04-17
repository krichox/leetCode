namespace ArrayProject.螺旋矩阵
{
    /*https://leetcode.cn/problems/rotate-image/description/*/
    // 
    public class Rotate_Image旋转矩阵 {
    public void Rotate(int[][] matrix) {
        var n = matrix.Length;
        var m = matrix[0].Length;
        for(var i = 0; i < n; i++)
        {
            for(var j = 0; j < i; j++)
            {
                var temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        for(var i = 0; i < n; i++)
        {
            Reverse(matrix[i]);
        }
    }

    private void Reverse(int[] arr)
    {
        var left = 0;
        var right = arr.Length - 1;
        while(left <= right)
        {
            var temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }
    }
    }
}