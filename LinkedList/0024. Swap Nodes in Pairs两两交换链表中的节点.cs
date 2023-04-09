namespace LinkedList {}

/*Given a linked list, swap every two adjacent nodes and return its head.You must solve the problem
    without modifying the values in the list's nodes(i.e., only nodes themselves may be changed.)*/

/*https://leetcode.cn/problems/swap-nodes-in-pairs/description/*/

public class SwapNodesInPairs
{
    public ListNode SwapPairs(ListNode head) {
        if(head == null)
        {
            return head;
        }
        var dummy = new ListNode(0);
        dummy.Next = head;
        var temp = dummy;
        while(temp.Next != null && temp.Next.Next != null)
        {
            var left = temp.Next;
            var right = temp.Next.Next;

            var tempRight = right.Next;
            right.Next = left;
            left.Next = tempRight;
            temp.Next = right;

            temp = temp.Next.Next;
        }

        return dummy.Next;
    }
}

