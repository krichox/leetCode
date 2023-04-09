using System.Collections.Generic;

namespace Backtracking.组合
{
    /*Given two integers n and k, return all possible combinations of k numbers chosen from the range [1, n].

You may return the answer in any order.

 

Example 1:

Input: n = 4, k = 2
Output: [[1,2],[1,3],[1,4],[2,3],[2,4],[3,4]]
Explanation: There are 4 choose 2 = 6 total combinations.
Note that combinations are unordered, i.e., [1,2] and [2,1] are considered to be the same combination.
Example 2:

Input: n = 1, k = 1
Output: [[1]]
Explanation: There is 1 choose 1 = 1 total combination.*/
    public class Combinations组合
    {
        IList<int> path = new List<int>();
        IList<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> Combine(int n, int k)
        {
            BackTracing(n, k, 1);
            return result;
        }

        // 递归算法的参数
        void BackTracing(int n, int k, int startIndex)
        {
            // 终止条件
            if (path.Count == k)
            {
                result.Add(new List<int>(path));
                return;
            }

            // 单层递归逻辑
            /*已经选择的元素个数：path.size();
    
            所需需要的元素个数为: k - path.size();
    
            列表中剩余元素（n-i） >= 所需需要的元素个数（k - path.size()）
    
            在集合n中至多要从该起始位置 : i <= n - (k - path.size()) + 1，开始遍历
    
            为什么有个+1呢，因为包括起始位置，我们要是一个左闭的集合。
    
            举个例子，n = 4，k = 3， 目前已经选取的元素为0（path.size为0），n - (k - 0) + 1 即 4 - ( 3 - 0) + 1 = 2。
    
            从2开始搜索都是合理的，可以是组合[2, 3, 4]。*/
            for (var i = startIndex; i <= n - (k - path.Count) + 1; i++)
            {
                path.Add(i);
                BackTracing(n, k, i + 1);
                // 回溯
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}