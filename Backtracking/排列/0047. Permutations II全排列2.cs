using System;
using System.Collections.Generic;

namespace Backtracking.排列
{
    /*https://leetcode.cn/problems/permutations-ii/
     Given a collection of numbers, nums, that might contain duplicates, return all possible unique permutations in any order.
Example 1:

Input: nums = [1,1,2]
Output:
[[1,1,2],
 [1,2,1],
 [2,1,1]]
Example 2:

Input: nums = [1,2,3]
Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]*/
    public class Permutations_II全排列2 {
        IList<int> path = new List<int>();
        IList<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> PermuteUnique(int[] nums) {
            var used = new bool[nums.Length];
            Array.Sort(nums);
            BackTracing(nums, used);
            return result;
        }

        void BackTracing(int[] nums, bool[] used)
        {
            // end condition
            if(path.Count == nums.Length)
            {
                result.Add(new List<int>(path));
                return;
            }

            for(var i = 0; i < nums.Length; i++)
            {
                if(used[i] )
                {
                    continue;
                }

                if(i > 0 && nums[i] == nums[i - 1] && used[i - 1] == false)
                {
                    continue;
                }

                path.Add(nums[i]);
                used[i] = true;
                BackTracing(nums, used);
                path.RemoveAt(path.Count - 1);
                used[i] = false;
            }
        }
    }
}