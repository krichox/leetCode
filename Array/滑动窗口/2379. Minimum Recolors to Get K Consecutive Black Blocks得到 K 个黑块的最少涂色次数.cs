using System;

namespace Array.滑动窗口
{
    /*https://leetcode.cn/problems/minimum-recolors-to-get-k-consecutive-black-blocks/description/?languageTags=csharp
     2379. Minimum Recolors to Get K Consecutive Black Blocks
提示
简单
63
相关企业
You are given a 0-indexed string blocks of length n, where blocks[i] is either 'W' or 'B', representing the color of the ith block. The characters 'W' and 'B' denote the colors white and black, respectively.

You are also given an integer k, which is the desired number of consecutive black blocks.

In one operation, you can recolor a white block such that it becomes a black block.

Return the minimum number of operations needed such that there is at least one occurrence of k consecutive black blocks.

 

Example 1:

Input: blocks = "WBBWWBBWBW", k = 7
Output: 3
Explanation:
One way to achieve 7 consecutive black blocks is to recolor the 0th, 3rd, and 4th blocks
so that blocks = "BBBBBBBWBW". 
It can be shown that there is no way to achieve 7 consecutive black blocks in less than 3 operations.
Therefore, we return 3.
Example 2:

Input: blocks = "WBWBBBW", k = 2
Output: 0
Explanation:
No changes need to be made, since 2 consecutive black blocks already exist.
Therefore, we return 0.*/
    public class Minimum_Recolors_to_Get_K_Consecutive_Black_Blocks得到_K_个黑块的最少涂色次数 {
        public int MinimumRecolors(string blocks, int k) {
            // 滑动窗口
            if(k > blocks.Length)
            {
                return -1;
            }
            var minValue = int.MaxValue;
            
            //定长滑动窗口
            //    for(var i = 0; i <= blocks.Length - k; i++)
            //    {
            //        var count = 0;
            //        for(var j = i; j < i + k; j++)
            //        {
            //            if(blocks[j] == 'W')
            //            {
            //                count++;
            //            }
            //        }

            //        if(count < minValue)
            //        {
            //            minValue = count;
            //        }
            //    }
            var left = 0;
            var right = 0;
            var count = 0;
            
            //  定义定长窗口
            while(right < k)
            {
                count += blocks[right] == 'W' ? 1 : 0;
                right++; 
            }
            // 左右开始滑动，维护窗口
            var result = count;
            while(right < blocks.Length)
            {
                count += blocks[right] == 'W' ? 1 : 0;
                count -= blocks[left] == 'W' ? 1 : 0;
                left++;
                right++;

                result = Math.Min(count, result);
            }

            return result;
        }
    }
}