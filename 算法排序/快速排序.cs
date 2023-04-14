using System;
using System.Collections.Concurrent;
using System.Net.Quic;

namespace 算法排序
{
    public class 快速排序
    {

        private Random _random = new();
        public int[] SortArray(int[] nums)
        {
            QuickSort(nums, 0, nums.Length - 1);
            return nums;
        }

        

        // 利用随机数解决升序和降序复杂为O(N^2)问题
        // 双路快排, 解决相同元素随机数失效问题
        void QuickSort(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return;
            }

            var pivotIndex = partition(nums, left, right);
            QuickSort(nums, left, pivotIndex - 1);
            QuickSort(nums, pivotIndex + 1, right);
        }

        private int partition(int[] nums, int left, int right)
        {
            // [left..right]
            var randomIndex = _random.Next(left, right);
            
            (nums[left], nums[randomIndex]) = (nums[randomIndex], nums[left]);

            var pivot = nums[left];
            // [left + 1, le) < pivot
            // (ge, right] > pivot

            var le = left + 1; // le -> less equal
            var ge = right; // ge -> greater than

            while (true)
            {
                while (le <= ge && nums[le] < pivot)
                {
                    le++;
                }

                while (le <= ge && nums[ge] > pivot)
                {
                    ge--;
                }

                // le 第一次来到大于等于pivot的位置
                // ge 第一次来到小于等于pivot的位置
                if (le >= ge)
                {
                    break;
                }
                
                (nums[le], nums[ge]) = (nums[ge], nums[le]);
                le++;
                ge--;
            }

            (nums[left], nums[ge]) = (nums[ge], nums[left]);

            return ge;
        }
        
    }
}