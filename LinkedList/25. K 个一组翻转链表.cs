namespace LinkedList
{
    /*https://leetcode.cn/problems/reverse-nodes-in-k-group/description/*/
    public class K_个一组翻转链表 {
        public ListNode ReverseKGroup(ListNode head, int k) {
            if(head == null)
            {
                return head;
            }
        
            var cur = head;
            // 不满足k长度不反转
            for(var i = 0; i < k; i++)
            {
                if(cur == null)
                {
                    return head;
                }
                cur = cur.Next;
            }
            var reversedHead = Reverse(head, cur);
            head.Next = ReverseKGroup(cur, k);

            return reversedHead;
        }
    
        // 反转[a, b)元素
        private ListNode Reverse(ListNode a, ListNode b)
        {
            
            var cur = a;
            ListNode pre = null;
        
            while(cur != b)
            {
                var Next = cur.Next;
                cur.Next = pre;
                pre = cur;
                cur = Next;
            }

            return pre;
        }
    
    }
}