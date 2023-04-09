using System;
using System.Collections.Generic;
using System.Linq;

namespace Backtracking.组合
{
    /*https://leetcode.cn/problems/combination-sum-ii/
     
     Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates where the candidate numbers sum to target.

Each number in candidates may only be used once in the combination.

Note: The solution set must not contain duplicate combinations.

 

Example 1:

Input: candidates = [10,1,2,7,6,1,5], target = 8
Output: 
[
[1,1,6],
[1,2,5],
[1,7],
[2,6]
]
Example 2:

Input: candidates = [2,5,2,1,2], target = 5
Output: 
[
[1,2,2],
[5]
]*/
    public class Combination_Sum_II组合总和_II {
        IList<int> path = new List<int>();
        IList<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
            Array.Sort(candidates);
            var used = new bool[candidates.Length];
            BackTracing(candidates, target, 0, used);
            return result;
        }

        void BackTracing(int[] candidates, int target, int startIndex, bool[] used)
        {
            // end condition
            if(path.Sum() == target)
            {
                result.Add(new List<int>(path));
                return;
            }

            // 递归逻辑
            for(var i = startIndex; i < candidates.Length; i++)
            {
                if(i > 0 && candidates[i] == candidates[i - 1] && used[i - 1] == false)
                {
                    continue;
                }

                if(path.Sum() + candidates[i] > target)
                {
                    break;
                }
            
                path.Add(candidates[i]);
                used[i] = true;
                BackTracing(candidates, target, i + 1, used);
                // 回溯
                path.RemoveAt(path.Count - 1);
                used[i] = false;
            }
        }
    }
}