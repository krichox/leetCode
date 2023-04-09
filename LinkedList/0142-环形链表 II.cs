namespace LinkedList
{
    /*https://leetcode.cn/problems/linked-list-cycle-ii/*/

/*Given the head of a linked list, return the node where the cycle begins. If there is no cycle, return null.

There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to (0-indexed). It is -1 if there is no cycle. Note that pos is not passed as a parameter.

Do not modify the linked list.


Example 1:
Input: head = [3,2,0,-4], pos = 1
Output: tail connects to node index 1
Explanation: There is a cycle in the linked list, where tail connects to the second node.

Example 2:
Input: head = [1,2], pos = 0
Output: tail connects to node index 0
Explanation: There is a cycle in the linked list, where tail connects to the first node.

Example 3:
Input: head = [1], pos = -1
Output: no cycle
Explanation: There is no cycle in the linked list.*/
    public class 环形链表Ii {
        public ListNode DetectCycle(ListNode head) {
            var slow = head;
            var fast = head;
            while(fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if(slow == fast)
                {
                    var index1 = head;
                    var index2 = fast;
                    while(index1 != index2)
                    {
                        index1 = index1.Next;
                        index2 = index2.Next;
                    
                    }
                
                    return index1;
                }
            }
            return null;
        }
    
        public ListNode DetectCycle2(ListNode head) {
            var slow = head;
            var fast = head;
            while(fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                // 相遇之后，头节点和相遇结点继续走
                if(slow == fast)
                {
                    while(slow != head)
                    {
                        slow = slow.Next;
                        head = head.Next;
                    }
                    return slow;
                }
            }

            return null;
        }
    
    
    }
}