namespace ArrayProject.双指针
{
    /*https://leetcode.cn/problems/merge-sorted-array/description/*/
    public class 合并两个有序数组 {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var sorted = new int[m + n];

            // 双指针比较，类似归并排序的merge
            int leftIndex = 0;
            int rightIndex = 0;
            //[0, m - 1], [m, m + n - 1]
            for (var i = 0; i < m + n; i++)
            {
                if (leftIndex == m)
                {
                    sorted[i] = nums2[rightIndex];
                    rightIndex++;
                }
                else if (rightIndex == n)
                {
                    sorted[i] = nums1[leftIndex];
                    leftIndex++;
                }
                else if (nums1[leftIndex] <= nums2[rightIndex])
                {
                    sorted[i] = nums1[leftIndex];
                    leftIndex++;
                }
                else
                {
                    sorted[i] = nums2[rightIndex];
                    rightIndex++;
                }
            }

            for (var i = 0; i < m + n; i++)
            {
                nums1[i] = sorted[i];
            }
        }
        // 指针单调递增移动最多移动m+n次，O(m+n)
        // O(m+n) 需要创建m+长度的数组
    }
}