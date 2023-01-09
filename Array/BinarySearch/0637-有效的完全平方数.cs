namespace Array.BinarySearch;

/*给定一个 正整数 num ，编写一个函数，如果 num 是一个完全平方数，则返回 true ，否则返回 false 。

进阶：不要 使用任何内置的库函数，如 sqrt 。

示例 1： 输入：num = 16
输出：true
示例 2：

输入：num = 14
输出：false

提示：
1 <= num <= 2 ^ 31 - 1*/

public class 有效的完全平方数
{
    public bool IsPerfectSquare(int num)
    {
        var left = 0;
        var right = num;
        while (left <= right)
        {
            var mid = (left + right) / 2;
            if ((long)mid * mid == num)
            {
                return true;
            }
            else if ((long)mid * mid < num)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }
}