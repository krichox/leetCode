using System.Collections.Generic;

namespace LinkedList
{
    /*https://leetcode.cn/problems/merge-two-sorted-lists/description/*/
    public class 合并两个有序链表 {
        // 类似合并两个有序数组，双指针
        public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
            var dummy = new ListNode(-1);
            var p = dummy;
            var p1 = list1;
            var p2 = list2;
            while(p1 != null && p2 != null)
            {
                if(p1.Val <= p2.Val)
                {
                    p.Next = p1;
                    p1 = p1.Next;

                }else
                {
                    p.Next = p2;
                    p2 = p2.Next;
                }

                p = p.Next;
            }
        
            if(p1 != null)
            {
                p.Next = p1;
            }

            if(p2 != null)
            {
                p.Next = p2;
            }

            return dummy.Next;
        }
    }
}