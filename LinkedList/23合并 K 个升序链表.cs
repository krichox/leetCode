using System.Collections.Generic;

namespace LinkedList
{
    /*https://leetcode.cn/problems/merge-k-sorted-lists/*/
    public class 合并_K_个升序链表
    {
        public ListNode MergeKLists(ListNode[] lists) {
            var dummy = new ListNode(-1);
        
            var cur = dummy;
            var pq = new PriorityQueue<ListNode, int>();
            foreach(var perNode in lists)
            {
                // 将每个链表的头结点加入最小堆里去， 注意判断空
                if(perNode != null)
                {
                    pq.Enqueue(perNode, perNode.Val);
                }

            }

            while(pq.Count != 0)
            {
                var node = pq.Dequeue();
                cur.Next = node;
                if(node.Next != null)
                {
                    pq.Enqueue(node.Next, node.Next.Val);
                }

                cur = cur.Next;
            }

            return dummy.Next;
        }
    }
}