namespace LinkedList
{
    /*https://leetcode.cn/problems/add-two-numbers/description/?show=1*/
    public class 两个链表相加
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            var p1 = l1;
            var p2 = l2;
            var dummy = new ListNode(0);
            var cur = dummy;
            int carry = 0;
            // 两条链表都走完，且不存在进行结束
            while(p1 != null || p2 != null || carry > 0)
            {
                int curValue = carry;
                if(p1 != null)
                {
                    curValue += p1.Val;
                    p1 = p1.Next;
                } 

                if(p2 != null)
                {
                    curValue += p2.Val;
                    p2 = p2.Next;
                }

                carry = curValue / 10;
                curValue = curValue % 10;
                cur.Next = new ListNode(curValue);
                cur = cur.Next;
            }
       
            return dummy.Next;
        }
    }
}