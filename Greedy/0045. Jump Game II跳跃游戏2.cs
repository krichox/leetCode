using System;

namespace Greedy
{
    /*https://leetcode.cn/problems/jump-game-ii/description/
     You are given a 0-indexed array of integers nums of length n. You are initially positioned at nums[0].

Each element nums[i] represents the maximum length of a forward jump from index i. In other words, if you are at nums[i], you can jump to any nums[i + j] where:

0 <= j <= nums[i] and
i + j < n
Return the minimum number of jumps to reach nums[n - 1]. The test cases are generated such that you can reach nums[n - 1].

 

Example 1:

Input: nums = [2,3,1,1,4]
Output: 2
Explanation: The minimum number of jumps to reach the last index is 2. Jump 1 step from index 0 to 1, then 3 steps to the last index.
Example 2:

Input: nums = [2,3,0,1,4]
Output: 2*/
    public class Jump_Game_II跳跃游戏2 {
        public int Jump(int[] nums) {
            if(nums.Length == 1)
            {
                return 0;
            }
            var jumpCount = 0;
            var curCover = 0;
            var maxCover = 0;
            for(var i = 0; i < nums.Length - 1; i++)
            {
                maxCover = Math.Max(maxCover, nums[i] + i);

                if(maxCover >= nums.Length - 1)
                {
                    jumpCount++;
                    break;
                
                }
                
                // 到了当前最大cover，跳跃次数加一，更新curCover
                if(curCover == i)
                {
                    jumpCount++;
                    curCover = maxCover;
                }


            }

            return jumpCount;

        }
    }
}