namespace LinkedList
{
    /*https://leetcode.cn/problems/middle-of-the-linked-list/description/*/
    public class Middle_of_the_Linked_List链表的中间节点 {
        private ListNode slow;
        private ListNode fast;
        public ListNode MiddleNode(ListNode head) {
            slow = head; 
            fast = head;
            // 慢指针走一步，快指针走两步
            while(fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }
        
            return slow;
        }
    }
}