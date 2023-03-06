namespace LinkedList {}

public class 移除链表元素
{
    public ListNode? RemoveElements(ListNode? head, int val)
    {
        if (head == null) 
        {
            return head;
        }

        var dummy = new ListNode(-1, head);
        var pre = dummy;
        var cur = head;

        while (cur != null)
        {
            if (cur.Val == val)
            {
                pre.Next = cur.Next;
            }
            else
            {
                pre = cur;
            }

            cur = cur.Next;
        }

        return dummy.Next;
    }
}

public partial class ListNode
{
    public readonly int Val;
    public ListNode? Next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.Val = val;
        this.Next = next;
    }
}