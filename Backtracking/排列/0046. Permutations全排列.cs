using System.Collections.Generic;

namespace Backtracking.排列
{
    /*https://leetcode.cn/problems/permutations/description/
     Given an array nums of distinct integers, return all the possible permutations. You can return the answer in any order.

 

Example 1:

Input: nums = [1,2,3]
Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
Example 2:

Input: nums = [0,1]
Output: [[0,1],[1,0]]
Example 3:

Input: nums = [1]
Output: [[1]]*/
    public class Permutations全排列 {
        IList<int> path = new List<int>();
        IList<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> Permute(int[] nums) {
            var used = new bool[nums.Length];
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
                if(used[i])
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