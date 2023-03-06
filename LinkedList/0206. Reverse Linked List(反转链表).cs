namespace LinkedList {}

/*https://leetcode.cn/problems/reverse-linked-list/*/
/*Given the head of a singly linked list, reverse the list, and return the reversed list.
。*/
public class ReverseLinkedList反转链表
{
    public ListNode ReverseList迭代(ListNode head)
    {
        ListNode prev = null;
        var cur = head;
        while (cur != null)
        {
            var next = cur.Next;
            cur.Next = prev;
            prev = cur;
            cur = next;
        }

        return prev;
    }

    public ListNode ReverseList递归(ListNode head)
    {
        if (head == null || head.Next == null)
        {
            return head;
        }

        var res = ReverseList递归(head.Next);
        head.Next.Next = head;
        head.Next = null;

        return res;
    }
    
    public ListNode ReverseList双指针(ListNode head) {
        if(head == null || head.Next == null)
        {
            return head;
        }

        var cur = head;

        while(head.Next != null)
        {
            var t = head.Next.Next;
            head.Next.Next = cur;
            cur = head.Next;
            head.Next = t;
        }

        return cur;
    }
}