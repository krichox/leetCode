using System;
using System.Collections.Generic;

namespace Array.前缀和
{
    /*https://leetcode.cn/problems/make-sum-divisible-by-p/description/
     Given an array of positive integers nums, remove the smallest subarray (possibly empty) such that the sum of the remaining elements is divisible by p. It is not allowed to remove the whole array.

Return the length of the smallest subarray that you need to remove, or -1 if it's impossible.

A subarray is defined as a contiguous block of elements in the array.

 

Example 1:

Input: nums = [3,1,4,2], p = 6
Output: 1
Explanation: The sum of the elements in nums is 10, which is not divisible by 6. We can remove the subarray [4], and the sum of the remaining elements is 6, which is divisible by 6.
Example 2:

Input: nums = [6,3,5,2], p = 9
Output: 2
Explanation: We cannot remove a single element to get a sum divisible by 9. The best way is to remove the subarray [5,2], leaving us with [6,3] with sum 9.
Example 3:

Input: nums = [1,2,3], p = 3
Output: 0
Explanation: Here the sum is 6. which is already divisible by 3. Thus we do not need to remove anything.*/
    public class Make_Sum_Divisible_by_P使数组和能被_P_整除 {
        public int minSubarray(int[] nums, int p)
        {
            // 前n项和对p取余的数组
            int x = 0;

            foreach (int num in nums) {
                x = (x + num) % p;
            }
        
            if (x == 0) {
                return 0;
            }

            var index  = new Dictionary<int, int>();

            int y = 0, res = nums.Length;
            // 遍历取余数组
            for(var i = 0; i < nums.Length; i++)
            {
                if (!index.ContainsKey(y)) {
                    index.Add(y, i);
                } else {
                    index[y] = i;
                }

                //(s[right](modp) - xmodp + p)modp = s[left]modp
                y = (y + nums[i]) % p;
                if (index.ContainsKey((y - x + p) % p)) {
                    res = Math.Min(res, i - index[(y - x + p) % p] + 1);
                }


            }

            return res == nums.Length ? -1 : res;
        }
    }
}