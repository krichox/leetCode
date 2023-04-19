namespace 算法排序
{
    /*https://leetcode.cn/problems/sort-an-array/description/*/
    public class Sort_an_Array排序一个数组 {
        public int[] SortArray(int[] nums) {
            var temp = new int[nums.Length];
            Sort(nums, 0, nums.Length - 1, temp);

            return nums;
        }

        private void Sort(int[] nums, int left, int right, int[] temp)
        {
            if(left == right)
            {
                return;
            }
            var mid = left + (right - left) / 2;
            Sort(nums, left, mid, temp);
            Sort(nums, mid + 1, right, temp);

            MergeSort(nums, left, mid, right, temp);
        }

        private void MergeSort(int[] nums, int left, int mid, int right, int[] temp)
        {
            // nums->temp
            for(var i = left; i <= right; i++)
            {
                temp[i] = nums[i];
            }

            var leftIndex = left;
            var rightIndex = mid + 1;

            for(var i = left; i <= right; i++)
            {

                if(leftIndex == mid + 1)
                {
                    nums[i] = temp[rightIndex];
                    rightIndex++;
                }
                else if(rightIndex == right + 1)
                {
                    nums[i] = temp[leftIndex];
                    leftIndex++;
                }
                else if(temp[leftIndex] <= temp[rightIndex])
                {
                    nums[i] = temp[leftIndex];
                    leftIndex++;
                }else
                {
                    nums[i] = temp[rightIndex];
                    rightIndex++;
                }
            }
        }
    }
}