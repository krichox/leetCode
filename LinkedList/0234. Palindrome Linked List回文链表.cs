namespace LinkedList
{
    /*https://leetcode.cn/problems/palindrome-linked-list/description/*/
    public class Palindrome_Linked_List回文链表 {
        ListNode pre;
        private bool IsPalindrome2(ListNode root)
        {
            if(root == null)
            {
                return true;
            }

            if(!IsPalindrome2(root.Next))
            {
                return false;
            }

            if(root.Val != pre.Val)
            {
                return false;
            }
            pre = pre.Next;

            return true;
        }
    }
}