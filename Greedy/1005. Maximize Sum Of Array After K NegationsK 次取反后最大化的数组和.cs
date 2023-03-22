using System;
using System.Linq;

namespace Greedy
{
    /*https://leetcode.cn/problems/maximize-sum-of-array-after-k-negations/
     Given an integer array nums and an integer k, modify the array in the following way:

choose an index i and replace nums[i] with -nums[i].
You should apply this process exactly k times. You may choose the same index i multiple times.

Return the largest possible sum of the array after modifying it in this way.

 

Example 1:

Input: nums = [4,2,3], k = 1
Output: 5
Explanation: Choose index 1 and nums becomes [4,-2,3].
Example 2:

Input: nums = [3,-1,0,2], k = 3
Output: 6
Explanation: Choose indices (1, 2, 2) and nums becomes [3,1,0,2].
Example 3:

Input: nums = [2,-3,-1,5,-4], k = 2
Output: 13
Explanation: Choose indices (1, 4) and nums becomes [2,3,-1,5,4].
 */
    public class Maximize_Sum_Of_Array_After_K_NegationsK_次取反后最大化的数组和
    {
        public int LargestSumAfterKNegations(int[] nums, int k)
        {
            Array.Sort(nums);
            var result = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0 && k > 0)
                {
                    nums[i] = -nums[i];
                    k--;
                }
            }


            if (k % 2 == 0)
            {
                result = nums.Sum();
            }

            if (k % 2 == 1)
            {
                result = nums.Sum() - 2 * nums.Min();
            }

            return result;
        }
    }
}