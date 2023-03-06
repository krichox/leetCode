namespace LinkedList {}
/*https://leetcode.cn/problems/remove-nth-node-from-end-of-list/*/

/*Given the head of a linked list, remove the nth node from the end of the list and return its head.*/
public class RemoveNthNodeFromEndOfList
{
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