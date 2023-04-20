namespace LinkedList
{
    /*https://leetcode.cn/problems/lian-biao-zhong-dao-shu-di-kge-jie-dian-lcof/description/*/
    public class 剑指_Offer_22__链表中倒数第k个节点
    {
        public ListNode GetKthFromEnd(ListNode head, int k) {

            return  FindNodeFromEnd(head, k);

        }

        ListNode FindNodeFromEnd(ListNode root, int k)
        {
            // 快指针先走
            var fast = root;
            for(var i = 0; i < k; i++)
            {
                fast = fast.Next;
            }
            var slow = root;
            while(fast != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return slow;
        }
    }
}