using System.Collections.Generic;

namespace QueueStack {}

/*https://leetcode.cn/problems/top-k-frequent-elements/*/
/*Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

Example 1:
Input: nums = [1,1,1,2,2,3], k = 2
Output: [1,2]
Example 2:

Input: nums = [1], k = 1
Output: [1]*/

/*这道题目主要涉及到如下三块内容：
要统计元素出现频率
对频率排序
找出前K个高频元素*/
public class 前K个高频出现元素
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dic = new Dictionary<int, int>();
        // 添加到dic
        for (var i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
            {
                dic[nums[i]]++;
            }
            else
            {
                dic.Add(nums[i], 1);
            }
        }

        var pq = new PriorityQueue<int, int>();
        // 添加到优先队列
        foreach (var kv in dic)
        {
            pq.Enqueue(kv.Key, kv.Value);
            if (pq.Count == k + 1)
            {
                pq.Dequeue();
            }
        }

        var res = new List<int>();
        while (pq.Count > 0)
        {
            res.Add(pq.Dequeue());
        }

        return res.ToArray();
    }
}