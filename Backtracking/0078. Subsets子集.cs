using System.Collections.Generic;

namespace Backtracking
{
    /*https://leetcode.cn/problems/subsets/description/
     Given an integer array nums of unique elements, return all possible 
subsets
 (the power set).

The solution set must not contain duplicate subsets. Return the solution in any order.

 

Example 1:

Input: nums = [1,2,3]
Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
Example 2:

Input: nums = [0]
Output: [[],[0]]*/
    public class Subsets子集 {
        IList<int> path = new List<int>();
        IList<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> Subsets(int[] nums) {
            BackTracing(nums, 0);
            return result;

        }

        void BackTracing(int[] nums, int startIndex)
        {
            result.Add(new List<int>(path));
            if(startIndex >= nums.Length)
            {
                return;
            }
    
            for(var i = startIndex; i < nums.Length; i++)
            {
                path.Add(nums[i]);
                BackTracing(nums, i + 1);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}