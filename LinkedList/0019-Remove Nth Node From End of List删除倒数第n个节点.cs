using System.Collections.Generic;

namespace LinkedList
{
    /*https://leetcode.cn/problems/remove-nth-node-from-end-of-list/*/

/*Given the head of a linked list, remove the nth node from the end of the list and return its head.*/
    public class RemoveNthNodeFromEndOfList
    {
        
        public ListNode RemoveNthFromEnd3(ListNode head, int n) {
            // 哨兵节点, 为了可以删除头节点
            var dummy = new ListNode(-1);
            dummy.Next = head;
            // 寻找倒数第n + 1个位置
            var res = FindFromEnd(dummy, n + 1);
            res.Next = res.Next.Next;
            return dummy.Next;
        }

        private ListNode FindFromEnd(ListNode head, int k)
        {
            var p1 = head;

            // p1 先走k部
            for(var i = 0; i < k; i++)
            {
                p1 = p1.Next;
            }
            var p2 = head;
            // p1和p2一起走，一直到p1走到null
            while(p1 != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }

            // p1走到空时，p2为倒数第n+1的位置

            return p2;
        }
        // 双指针求解
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
            {
                return head;
            }

            var dummy = new ListNode(0);
            dummy.Next = head;
            var slow = dummy;
            var fast = dummy;

            for (var i = 0; i < n; i++)
            {
                fast = fast.Next;
            }

            while (fast.Next != null)
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            slow.Next = slow.Next.Next;


            return dummy.Next;
        }


        public ListNode RemoveNthFromEnd1(ListNode head, int n)
        {
            if (head == null)
            {
                return head;
            }

            var dummy = new ListNode(0);
            dummy.Next = head;
            var prev = dummy;

            var size = 0;
            while (prev.Next != null)
            {
                size++;
                prev = prev.Next;
            }

            if (n > size)
            {
                return head;
            }

            var cur = dummy;

            for (var i = 0; i < size - n; i++)
            {
                cur = cur.Next;
            }

            var temp = cur.Next.Next;
            cur.Next = temp;

            return dummy.Next;
        }
    }
}