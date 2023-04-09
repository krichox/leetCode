namespace LinkedList
{
    /*https://leetcode.cn/problems/linked-list-cycle/description/*/
    public class Linked_List_Cycle环形链表 {
        public bool HasCycle(ListNode head) {
            var slow = head;
            var fast = head;
            while(fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if(slow == fast)
                {
                    return true;
                }
            }

            return false;
        }
    }
}