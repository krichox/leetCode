using System.Collections.Generic;
using System.Linq;

namespace Backtracking.组合
{
    /*https://leetcode.cn/problems/combination-sum-iii/
     Find all valid combinations of k numbers that sum up to n such that the following conditions are true:

Only numbers 1 through 9 are used.
Each number is used at most once.
Return a list of all possible valid combinations. The list must not contain the same combination twice, and the combinations may be returned in any order.

 

Example 1:

Input: k = 3, n = 7
Output: [[1,2,4]]
Explanation:
1 + 2 + 4 = 7
There are no other valid combinations.
Example 2:

Input: k = 3, n = 9
Output: [[1,2,6],[1,3,5],[2,3,4]]
Explanation:
1 + 2 + 6 = 9
1 + 3 + 5 = 9
2 + 3 + 4 = 9
There are no other valid combinations.
Example 3:

Input: k = 4, n = 1
Output: []
Explanation: There are no valid combinations.
Using 4 different numbers in the range [1,9], the smallest sum we can get is 1+2+3+4 = 10 and since 10 > 1, there are no valid combination.*/
    public class Combination_Sum_III组合总和_III {
        IList<IList<int>> result = new List<IList<int>>();
        IList<int> path = new List<int>();
        public IList<IList<int>> CombinationSum3(int k, int n) {
            CombinationSum(k, n, 1);
            return result;
        }

        void CombinationSum(int k, int n, int startIndex)
        {
            // 剪枝
            if(path.Sum() > n)
            {
                return;
            }
            // 终止条件
            if(path.Count == k)
            {
                if(path.Sum() == n)
                {
                    result.Add(new List<int>(path));
 
                }
                return;
            }

            // 单次遍历
            for(var i = startIndex; i <= 9 - (k - path.Count) + 1; i++)
            {
                path.Add(i);
                CombinationSum(k, n , i + 1);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}