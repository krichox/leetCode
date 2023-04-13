using System;

namespace ArrayProject
{
    /*https://leetcode.cn/problems/next-permutation/description/*/
    public class Next_Permutation下一个排列 {
        public void NextPermutation(int[] nums) {
            var n = nums.Length;

            // // 找到右边一个较大的数，和尽量左边较小的数进行交换
            // // 暴力求解
            // for(var i = n - 1; i >= 0; i--)
            // {
            //     for(var j = n - 1; j > i; j--)
            //     {
            //         if(nums[j] > nums[i])
            //         {
            //
            //             (nums[i], nums[j]) = (nums[j], nums[i]);
            //             Array.Sort(nums, i + 1, n - i - 1);
            //             return;
            //         }
            //     }
            // }
            //
            // Array.Sort(nums);
        

            var i = n - 2;
            while(i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }

            if(i != -1)
            {
                var j = n - 1;
                while(j > i && nums[j] <= nums[i])
                {
                    j--;
                }
                (nums[i], nums[j]) = (nums[j], nums[i]);
                Reverse(nums, i + 1, n - 1);
            }else
            {
                // 此时为[i+1, end]递减序列
                Reverse(nums, 0, n - 1);
            }
        }

        private void Reverse(int[] nums, int left, int right)
        {
            while(left < right)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);
                left++;
                right--;
            }
        }

        
    }
}