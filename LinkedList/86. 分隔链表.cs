namespace LinkedList
{
    /*https://leetcode.cn/problems/partition-list/description/*/
    public class 分隔链表 {
        // 把链表区分成两个链表，小于和大于等于两个链表，然后再进行拼接
        public ListNode Partition(ListNode head, int x) {
            var leNodeDummy = new ListNode(0);
            var gteNodeDummy = new ListNode(0);
            var p1 = leNodeDummy;
            var p2 = gteNodeDummy;
            var cur = head;
            while(cur != null)
            {
                if(cur.Val < x)
                {
                    p1.Next = cur;
                    p1 = p1.Next;
                }else
                {
                    p2.Next = cur;
                    p2 = p2.Next;
                }
                // 需要把当前cur.next 置为空，防止重复引用
                var temp  = cur.Next;
                cur.Next = null;
                cur = temp;
            }
            p1.Next = gteNodeDummy.Next;

            return leNodeDummy.Next;
        }
    }
}