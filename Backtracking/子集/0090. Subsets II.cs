using System;
using System.Collections.Generic;

namespace Backtracking
{
    /*https://leetcode.cn/problems/subsets-ii/
     Given an integer array nums that may contain duplicates, return all possible 
subsets
 (the power set).

The solution set must not contain duplicate subsets. Return the solution in any order.

 

Example 1:

Input: nums = [1,2,2]
Output: [[],[1],[1,2],[1,2,2],[2],[2,2]]
Example 2:

Input: nums = [0]
Output: [[],[0]]*/
    public class Subsets_II
    {
        IList<int> path = new List<int>();
        IList<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            var used = new bool[nums.Length];
            Array.Sort(nums);
            BackTracing(nums, 0, used);
            return result;
        }

        void BackTracing(int[] nums, int startIndex, bool[] used)
        {
            // end condition
            result.Add(new List<int>(path));
            if (startIndex >= nums.Length)
            {
                return;
            }

            for (var i = startIndex; i < nums.Length; i++)
            {
                if (i > startIndex && nums[i - 1] == nums[i])
                {
                    continue;
                }

                path.Add(nums[i]);
                used[i] = true;
                BackTracing(nums, i + 1, used);
                used[i] = false;
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}