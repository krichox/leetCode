namespace ArrayProject.BinarySearch
{
    /*https://leetcode.cn/problems/search-in-rotated-sorted-array/description/*/
    public class 搜索旋转排序数组 {
        public int Search(int[] nums, int target) {
            int left = 0; int right = nums.Length - 1;
            if(nums.Length == 0)
            {
                return -1;
            }
            if(nums.Length == 1 && nums[0] != target)
            {
                return -1;
            }
            while(left <= right)
            {
                var mid = left + (right - left) / 2;
                if(nums[mid] == target)
                {
                    return mid;
                    // [0, mid] 是否升序，且小于==target
                }
                if(nums[0] <= nums[mid])
                {
                    if(nums[0] <= target && target < nums[mid])
                    {
                        right = mid - 1;
                    }else
                    {
                        left = mid + 1;
                    }
                }else
                {
                    if(nums[mid] < target && target <= nums[nums.Length - 1])
                    {
                        left = mid + 1;
                    }else
                    {
                        right = mid - 1;
                    }
                }
            }

            return -1;
        }
    }
}