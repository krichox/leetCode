using LinkedList;

namespace BinaryTree
{
    /*https://leetcode.cn/problems/convert-sorted-list-to-binary-search-tree/description/?show=1*/
    public class 有序链表转换二叉搜索树 {
        // O(nlogN)
        // O(logn) -> 递归深度
        public TreeNode SortedListToBST(ListNode head) {
            // var list = new List<int>();
            // while(head != null)
            // {
            //     list.Add(head.Val);
            //     head = head.Next;
            // }

            return SortedListToBst2(head, null);

        }
        // [Left, Right)
        public TreeNode SortedListToBst2(ListNode Left, ListNode Right)
        {
            if(Left == Right)
            {
                return null;
            }
            var mid = FindMidNode(Left, Right);
            var root = new TreeNode(mid.Val);
            root.Left = SortedListToBst2(Left, mid);
            root.Right = SortedListToBst2(mid.Next, Right);

            return root;
        }

        // public TreeNode SortedListToBst(List<int> list, int Left, int Right)
        // {
        //     if(Left > Right)
        //     {
        //         return null;
        //     }
        //     var mid = Left + (Right - Left) / 2;
        //     var root = new TreeNode(list[mid]);
        //     root.Left = SortedListToBst(list, Left, mid - 1);
        //     root.Right = SortedListToBst(list, mid + 1, Right);

        //     return root;
        // }
        // [Left, Right)
        private ListNode FindMidNode(ListNode Left, ListNode Right)
        {
            var slow = Left;
            var fast = Left;
            while(fast != Right && fast.Next != Right)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow;
        }
    }
}