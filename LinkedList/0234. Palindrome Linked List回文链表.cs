using System.Collections.Generic;

namespace LinkedList
{
    /*https://leetcode.cn/problems/palindrome-linked-list/description/*/
    public class Palindrome_Linked_List回文链表
    {
        ListNode pre;

        private bool IsPalindrome2(ListNode root)
        {
            if (root == null)
            {
                return true;
            }

            if (!IsPalindrome2(root.Next))
            {
                return false;
            }

            if (root.Val != pre.Val)
            {
                return false;
            }

            pre = pre.Next;

            return true;
        }

        public bool IsPalindrome3(ListNode head)
        {
            pre = head;
            var cur = head;
            List<int> res = new();
            while (cur != null)
            {
                res.Add(cur.Val);
                cur = cur.Next;
            }

            return isPalindrome(res);
        }

        private bool isPalindrome(IList<int> list)
        {
            int left = 0, right = list.Count - 1;

            while (left <= right)
            {
                if (list[left] != list[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }


        private ListNode FindMidNode(ListNode root)
        {
            var slow = root;
            var fast = root;
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow;
        }

        private ListNode ReverseNode(ListNode root)
        {
            ListNode pre = null;
            var cur = root;
            while (cur != null)
            {
                var Next = cur.Next;
                cur.Next = pre;
                pre = cur;
                cur = Next;
            }

            return pre;
        }

        public bool main1(ListNode head)

        {
            var mid = FindMidNode(head);
            var reverseNode = ReverseNode(mid);
            ListNode head1 = reverseNode;
            ListNode head2 = head;
            while(head1 != null && head2 != null)
            {
                if(head1.Val != head2.Val)
                {
                    return false;
                }
                head1 = head1.Next;
                head2 = head2.Next;
            }

            return true;
        }
    }

}