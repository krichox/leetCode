using System.Collections.Generic;
using LinkedList;

namespace MonotonicStack
{
    /*https://leetcode.cn/problems/next-greater-node-in-linked-list/description/*/
    public class 链表中的下一个更大节点 {
        public int[] NextLargerNodes(ListNode head) {
            var nodeList = new List<int>();
            var cur = head;
            while(cur != null)
            {
                nodeList.Add(cur.Val);
                cur = cur.Next;
            }

            var result = new int[nodeList.Count];
            var stack = new Stack<int>();
            stack.Push(0);

            for(var i = 1; i < nodeList.Count; i++)
            {
                if(nodeList[i] > nodeList[stack.Peek()])
                {
                    while(stack.Count != 0 && nodeList[i] >  nodeList[stack.Peek()])
                    {
                        result[stack.Peek()] = nodeList[i];
                        stack.Pop();
                    }
                }
                stack.Push(i);
            }

            return result;
        }

        // 时间复杂度O(n), 空间复杂度(O(n))
    }
}