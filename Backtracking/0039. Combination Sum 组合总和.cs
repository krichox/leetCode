using System;
using System.Collections.Generic;
using System.Linq;

namespace Backtracking
{
    /*https://leetcode.cn/problems/combination-sum/description/
     Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.

The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the 
frequency
 of at least one of the chosen numbers is different.

The test cases are generated such that the number of unique combinations that sum up to target is less than 150 combinations for the given input.

 

Example 1:

Input: candidates = [2,3,6,7], target = 7
Output: [[2,2,3],[7]]
Explanation:
2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times.
7 is a candidate, and 7 = 7.
These are the only two combinations.
Example 2:

Input: candidates = [2,3,5], target = 8
Output: [[2,2,2,2],[2,3,3],[3,5]]
Example 3:

Input: candidates = [2], target = 1
Output: []*/
    public class Combination_Sum_组合总和
    {
        List<int> path = new List<int>();
        IList<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            
            var used = new bool[candidates.Length];
            // 将数组排序
            Array.Sort(candidates);
            BackTracing(candidates, target, 0);
            return result;
        }

        void BackTracing(int[] candidates, int target, int startIndex)
        {
            // 终止条件
            if (path.Sum() == target)
            {
                result.Add(new List<int>(path));
                return;
            }

            // 单次递归
            for (var i = startIndex; i < candidates.Length; i++)
            {
                // 此处不加1，每个节点都可以重复
                // 剪枝
                if (path.Sum() + candidates[i] > target)
                {
                    break;
                }

                path.Add(candidates[i]);
                BackTracing(candidates, target, i);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}