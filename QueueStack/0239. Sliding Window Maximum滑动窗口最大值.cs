using System.Collections.Generic;

namespace QueueStack
{
    /*https://leetcode.cn/problems/sliding-window-maximum/*/
/*You are given an array of integers nums, there is a sliding window of size k which is moving from the very left of the array to the very right. You can only see the k numbers in the window. Each time the sliding window moves right by one position.

Example 1:

Input: nums = [1,3,-1,-3,5,3,6,7], k = 3
Output: [3,3,5,5,6,7]
Explanation: 
Window position                Max
---------------               -----
[1  3  -1] -3  5  3  6  7       3
 1 [3  -1  -3] 5  3  6  7       3
 1  3 [-1  -3  5] 3  6  7       5
 1  3  -1 [-3  5  3] 6  7       5
 1  3  -1  -3 [5  3  6] 7       6
 1  3  -1  -3  5 [3  6  7]      7
Example 2:

Input: nums = [1], k = 1
Output: [1]
Return the max sliding window.
*/



// 保持为单调递减栈，最大值取first
    public class 滑动窗口最大值 {
        public int[] MaxSlidingWindow(int[] nums, int k) {
            var len = nums.Length;
            var result = new int[len - k + 1];
            var dq = new LinkedList<int>();
            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
            for(var i = 0; i < len; i++)
            {
                // 如果新元素大于队尾的元素
                while(dq.Count != 0 && nums[i] >= nums[dq.Last.Value])
                {
                    dq.RemoveLast();
                }

                // 判断队首的有效性
                if(dq.Count != 0 && dq.First.Value < i - k + 1)
                {
                    dq.RemoveFirst();
                }

                // 添加到队尾
                dq.AddLast(i);
                // 添加到result里
                if(i >= k - 1)
                {
                    result[i - k + 1] = nums[dq.First.Value];
                }

            }

            return result;
        }
        
        // 单调栈版本
        public int[] MaxSlidingWindow2(int[] nums, int k) {
            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
            var len = nums.Length;
            var res = new int[len - k + 1];
            for(var i = 0; i < len; i++)
            {
                pq.Enqueue(i, nums[i]);

                while(pq.Count > k && pq.Peek() <= i - k)
                {
                    pq.Dequeue();
                }

                if(i >= k - 1)
                {
                    res[i - k + 1] = nums[pq.Peek()];
                }
            }

            return res;
        }
    }
}