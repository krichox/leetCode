using System;
using System.Xml.Xsl;

namespace 算法排序
{
    // 二叉树的后序遍历
    public class 归并排序
    {

        public void Sort(int[] nums)
        {
            var temp = new int[nums.Length];
            MergeSort(nums, 0, nums.Length - 1, temp);
        }

        private void MergeSort(int[] nums, int left, int right, int[] temp)
        {
            // 单个元素不需要排序
            if (left == right)
            {
                return;
            }

            var mid = left + (right - left) / 2;
            // [left,mid]
            MergeSort(nums, left, mid, temp);
            
            //[mid + 1, right]
            MergeSort(nums, mid + 1, right, temp);
            
            Merge(nums, left, mid, right, temp);
        }

        private void Merge(int[] nums, int left, int mid, int right, int[] temp)
        {
            // 复制到临时数组上
            for (var i = left; i <= right; i++)
            {
                temp[i] = nums[i];
            }
            
            // 双指针合并两个数组
            int leftIndex = left;
            int rightIndex = mid + 1;
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
        }
    }
}