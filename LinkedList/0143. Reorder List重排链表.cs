namespace LinkedList
{
    /*https://leetcode.cn/problems/reorder-list/description/*/
    public class Reorder_List重排链表 {
    
        public void ReorderList(ListNode head) {
            var mid = FindMidNode(head);
            var head2 = ReverseNode(mid);
            while(head2.Next != null)
            {
                var head1Next = head.Next;
                var head2Next = head2.Next;
                head.Next = head2;
                head2.Next = head1Next;
                head = head1Next;
                head2 = head2Next;
            }
        }

        ListNode FindMidNode(ListNode root)
        {
            var slow = root;
            var fast = root;
            while(fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            return slow;

        }

        ListNode ReverseNode(ListNode root)
        {
            ListNode pre = null;
            var cur = root;
            while(cur != null)
            {
                var tempNext = cur.Next;
                cur.Next = pre;
                pre = cur;
                cur = tempNext;
            }

            return pre;
        }
    }
}