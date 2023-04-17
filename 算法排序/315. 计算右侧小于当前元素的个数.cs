using System.Collections.Generic;

namespace 算法排序
{
    /*https://leetcode.cn/problems/count-of-smaller-numbers-after-self/description/*/
    public class 计算右侧小于当前元素的个数 {
        public IList<int> CountSmaller(int[] nums) {
            var result = new int[nums.Length];
            if(nums.Length < 2)
            {
                return result;
            }
            var temp = new int[nums.Length];
            var index = new int[nums.Length];
            for(var i = 0; i < index.Length; i++)
            {
                index[i] = i;
            }

            SortAndGetCountSmaller(nums, 0, nums.Length - 1, temp, result, index);

            return result;
        }

        void  SortAndGetCountSmaller(int[] nums, int left, int right, int[] temp, int[] result, int[] index)
        {
            if(left == right)
            {
                return;
            }
            var mid = left + (right - left) / 2;
            SortAndGetCountSmaller(nums, left, mid, temp, result, index);
            SortAndGetCountSmaller(nums, mid + 1, right, temp, result, index);

            MergeAndCountSmaller(nums, left, mid, right, temp, result, index);
        }

        private void MergeAndCountSmaller(int[] nums, int left, int mid, int right, int[] temp, int[] result, int[] index)
        {
            // nums-> index
            for(var i = left; i <= right; i++)
            {
                temp[i] = index[i];
            }

            var leftIndex = left;
            var rightIndex = mid + 1;

            for(var i = left; i <= right; i++)
            {
                if(leftIndex == mid + 1)
                {
                    index[i] = temp[rightIndex];
                    rightIndex++;
                }
                else if(rightIndex == right + 1)
                {
                    index[i] = temp[leftIndex];
                    leftIndex++;
                    result[index[i]] += (right - mid);
                }
                else if(nums[temp[leftIndex]] <= nums[temp[rightIndex]])
                {
                    index[i] = temp[leftIndex];
                    leftIndex++;
                    result[index[i]] += rightIndex - mid - 1;
                }else
                {
                    index[i] = temp[rightIndex];
                    rightIndex++;
                }
            }
        }
    }
}