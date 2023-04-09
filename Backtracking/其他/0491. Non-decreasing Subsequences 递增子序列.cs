using System.Collections.Generic;

namespace Backtracking.其他
{
    /*https://leetcode.cn/problems/non-decreasing-subsequences/description/
     Given an integer array nums, return all the different possible non-decreasing subsequences of the given array with at least two elements. You may return the answer in any order.

 

Example 1:

Input: nums = [4,6,7,7]
Output: [[4,6],[4,6,7],[4,6,7,7],[4,7],[4,7,7],[6,7],[6,7,7],[7,7]]
Example 2:

Input: nums = [4,4,3,2,1]
Output: [[4,4]]*/
    public class Non_decreasing_Subsequences_递增子序列
    {
        IList<int> path = new List<int>();
        IList<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> FindSubsequences(int[] nums)
        {
            //题目非递减子集(组合问题)
            BackTracing(nums, 0);
            return result;
        }

        void BackTracing(int[] nums, int startIndex)
        {
            // end condition
            if (path.Count >= 2)
            {
                result.Add(new List<int>(path));
            }

            var set = new HashSet<int>();
            // 递归
            for (var i = startIndex; i < nums.Length; i++)
            {
                // 剪枝   
                if (set.Contains(nums[i]) || path.Count > 0 && nums[i] < path[path.Count - 1])
                {
                    continue;
                }

                set.Add(nums[i]);
                path.Add(nums[i]);
                BackTracing(nums, i + 1);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}