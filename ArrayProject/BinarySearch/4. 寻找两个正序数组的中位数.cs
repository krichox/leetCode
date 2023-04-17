using System;

namespace ArrayProject.BinarySearch
{
    /*https://leetcode.cn/problems/median-of-two-sorted-arrays/description/*/
    public class 寻找两个正序数组的中位数 {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            // 保证nums1的长度更小
            if(nums1.Length > nums2.Length)
            {
                int[] temp = nums1;
                nums1 = nums2;
                nums2 = temp;
            }

            int n = nums1.Length;
            int m = nums2.Length;
            int left = 0; // nums1的做左分索引
            int right = n; // num1的右部分索引
            while(left <= right)
            {
                // 在nums1中选择分割线
                int partition1 = (left + right) / 2;
                // 在nums2中选择分割线
                int partition2 = (m + n + 1) / 2 - partition1;
            
                var maxLeft1 = partition1 == 0 ? int.MinValue : nums1[partition1 - 1];
                var minRight1 = partition1 == n ? int.MaxValue : nums1[partition1];

                var maxLeft2 = partition2 == 0 ? int.MinValue : nums2[partition2 - 1];
                var minRight2 = partition2 == m ? int.MaxValue : nums2[partition2];

                // 左边最大值都小于右边最小值, 则找到最大值
                if(maxLeft1 <= minRight2 && maxLeft2 <= minRight1)
                {
                    // 如果是偶数
                    if( (m + n) % 2 == 0 )
                    {
                        return ((double)Math.Max(maxLeft1, maxLeft2) + (double)Math.Min(minRight1, minRight2)) / 2;
                    }else 
                    {
                        return (double)Math.Max(maxLeft1, maxLeft2);
                    }
                }
                else if(maxLeft1 > minRight2)
                {
                    //  分割线左移
                    right = partition1 - 1;
                }else
                {
                    // 分割线右移
                    left = partition1 + 1;
                }
            }

            return -1;
        }
    }
}