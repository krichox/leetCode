namespace LinkedList {}

/*https://leetcode.cn/problems/intersection-of-two-linked-lists-lcci/*/

/*Given two (singly) linked lists, determine if the two lists intersect. Return the inter­ secting node. Note that the intersection is defined based on reference, not value. That is, if the kth node of the first linked list is the exact same node (by reference) as the jth node of the second linked list, then they are intersecting.

Example 1:

Input: intersectVal = 8, listA = [4,1,8,4,5], listB = [5,0,1,8,4,5], skipA = 2, skipB = 3
Output: Reference of the node with value = 8
Input Explanation: The intersected node's value is 8 (note that this must not be 0 if the two lists intersect). From the head of A, it reads as [4,1,8,4,5]. From the head of B, it reads as [5,0,1,8,4,5]. There are 2 nodes before the intersected node in A; There are 3 nodes before the intersected node in B.
Example 2:

Input: intersectVal = 2, listA = [0,9,1,2,4], listB = [3,2,4], skipA = 3, skipB = 1
Output: Reference of the node with value = 2
Input Explanation: The intersected node's value is 2 (note that this must not be 0 if the two lists intersect). From the head of A, it reads as [0,9,1,2,4]. From the head of B, it reads as [3,2,4]. There are 3 nodes before the intersected node in A; There are 1 node before the intersected node in B.
Example 3:

Input: intersectVal = 0, listA = [2,6,4], listB = [1,5], skipA = 3, skipB = 2
Output: null
Input Explanation: From the head of A, it reads as [2,6,4]. From the head of B, it reads as [1,5]. Since the two lists do not intersect, intersectVal must be 0, while skipA and skipB can be arbitrary values.
Explanation: The two lists do not intersect, so return null.
Notes:

If the two linked lists have no intersection at all, return null.
The linked lists must retain their original structure after the function returns.
You may assume there are no cycles anywhere in the entire linked structure.
Your code should preferably run in O(n) time and use only O(1) memory.*/
public class IntersectionOfTwoLinkedListsLcci
{
    /*双指针*/
    public class Solution
    {
        // 方法一
        public ListNode GetIntersectionNode1(ListNode headA, ListNode headB)
        {
            var curA = headA;
            var curB = headB;
            while (curA != curB)
            {
                curA = curA == null ? headB : curA.Next;
                curB = curB == null ? headA : curB.Next;
            }

            return curA;
        }

        //方法2 
        public ListNode GetIntersectionNode2(ListNode headA, ListNode headB)
        {
            var lenA = 0;
            var lenB = 0;
            var curA = new ListNode(0);
            var curB = new ListNode(0);
            curA.Next = headA;
            curB.Next = headB;
            while (curA != null)
            {
                curA = curA.Next;
                lenA++;
            }

            while (curB != null)
            {
                curB = curB.Next;
                lenB++;
            }

            curA = headA;
            curB = headB;

            if (lenB > lenA)
            {
                // swap len
                (lenA, lenB) = (lenB, lenA);

                // swap node
                (curA, curB) = (curB, curA);
            }

            var gap = lenA - lenB;
            for (var i = 0; i < gap; i++)
            {
                curA = curA.Next;
            }

            while (curA != null)
            {
                if (curA == curB)
                {
                    return curA;
                }

                curA = curA.Next;
                curB = curB.Next;
            }

            return null;
        }
    }
}