namespace 算法排序
{
    /*https://leetcode.cn/problems/reverse-pairs/description/*/
    public class 翻转对
    {
        public int ReversePairs(int[] nums)
        {
            if (nums == null)
            {
                return 0;
            }

            // 归并排序
            if (nums.Length < 2)
            {
                return 0;
            }

            var temp = new int[nums.Length];
            return MergeSort(nums, 0, nums.Length - 1, temp);
        }

        int MergeSort(int[] nums, int left, int right, int[] temp)
        {
            if (left == right)
            {
                return 0;
            }

            var mid = left + (right - left) / 2;
            var leftReversePairs = MergeSort(nums, left, mid, temp);
            var rightReversePairs = MergeSort(nums, mid + 1, right, temp);

            var crossReversePairs = GetReversePairs(nums, left, mid, right, temp);
            return leftReversePairs + rightReversePairs + crossReversePairs;
        }

        int GetReversePairs(int[] nums, int left, int mid, int right, int[] temp)
        {
            // nums-> temp
            for (var i = left; i <= right; i++)
            {
                temp[i] = nums[i];
            }

            var leftIndex = left;
            var rightIndex = mid + 1;
            var count = 0;

            var end = mid + 1;
            for (var i = left; i <= mid; i++)
            {

                while (end <= right && (long) nums[i] > (long) nums[end] * 2)
                {
                    end++;
                }

                count += end - (mid + 1);
            }

            for (var i = left; i <= right; i++)
            {

                if (leftIndex == mid + 1)
                {
                    nums[i] = temp[rightIndex];
                    rightIndex++;
                }
                else if (rightIndex == right + 1)
                {
                    nums[i] = temp[leftIndex];
                    leftIndex++;
                }
                else if (temp[leftIndex] <= temp[rightIndex])
                {
                    nums[i] = temp[leftIndex];
                    leftIndex++;
                }
                else
                {
                    nums[i] = temp[rightIndex];
                    rightIndex++;
                }
            }

            return count;
        }
    }
}