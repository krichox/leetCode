namespace Array.BinarySearch
{
    
}

/*给你一个按照非递减顺序排列的整数数组 nums，和一个目标值 target。请你找出给定目标值在数组中的开始位置和结束位置。

如果数组中不存在目标值 target，返回[-1, -1]。

你必须设计并实现时间复杂度为 O(log n)
的算法解决此问题。


示例 1：

输入：nums = [5,7,7,8,8,10], target = 8
输出：
[3,4]
示例 2：

输入：nums = [5,7,7,8,8,10], target = 6
输出：
[-1,-1]
示例 3：

输入：nums = [], target = 0
输出：
[-1,-1]


提示：

0 <= nums.length <= 105
- 109 <= nums[i] <= 109
nums 是一个非递减数组
- 109 <= target <= 109*/


public class 在排序数组中查找元素的第一个和最后一个位置
{
    public int[] SearchRange(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        var mid = 0;
        var l = left;
        var r = right;
        // 从左向右逼近
        while (left < right)
        {
            mid = (right + left) / 2;
            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        if (left > right || nums[left] != target)
        {
            return new[] { -1, -1 };
        }

        // 从右向左逼近
        while (l < r)
        {
            mid = (l + r) / 2 + 1;
            if (nums[mid] > target)
            {
                r = mid - 1;
            }
            else
            {
                l = mid;
            }
        }

        return new[] { left, r };
    }
    
    // 更好的解法
    // L -1 < target
    // R + 1 >= target
    public int[] SearchRange2(int[] nums, int target) {
        var start = lowBound(nums, target);
        if(start == nums.Length || nums[start] != target)
        {
            return new int[] {-1, -1};
        }
        var end = lowBound(nums, target + 1) - 1;
        
        return new int[] {start, end};
    }

    private int lowBound(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while(left <= right)
        {
            var mid = left + (right - left) / 2;

            if(nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left;
    }
}