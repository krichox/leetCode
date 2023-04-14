using System;

namespace ArrayProject.排序
{
    /*https://leetcode.cn/problems/sort-colors/description/*/
    public class Sort_Colors颜色分类 {
        Random random = new Random();
        public void SortColors(int[] nums) {
            QuickSort(nums, 0, nums.Length - 1);
        }

        private void QuickSort(int[] nums, int left, int right)
        {
            if(left > right)
            {
                return;
            }

            var povitIndex = partition(nums, left, right);
            QuickSort(nums, left, povitIndex - 1);
            QuickSort(nums, povitIndex + 1, right);
        }

        private int partition(int[] nums, int left, int right)
        {
            // 获取随机index
            var randomIndex = random.Next(left, right);

            (nums[left], nums[randomIndex]) = (nums[randomIndex], nums[left]);
            var povit = nums[left];
            var le = left + 1;
            var ge = right;

            while(true)
            {
                while(le <= ge && nums[le] < povit)
                {
                    le++;
                }

                while(le <= ge && nums[ge] > povit)
                {
                    ge--;
                }

                if(le >= ge)
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