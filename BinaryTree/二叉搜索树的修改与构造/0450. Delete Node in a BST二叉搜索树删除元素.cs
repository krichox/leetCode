using System.Collections.Generic;

namespace BinaryTree
{
    /*https://leetcode.cn/problems/delete-node-in-a-bst/
     Given a root node reference of a BST and a key, delete the node with the given key in the BST. Return the root node reference (possibly updated) of the BST.

Basically, the deletion can be divided into two stages:

Search for a node to remove.
If the node is found, delete the node.
 

Example 1:


Input: root = [5,3,6,2,4,null,7], key = 3
Output: [5,4,6,2,null,null,7]
Explanation: Given key to delete is 3. So we find the node with value 3 and delete it.
One valid answer is [5,4,6,2,null,null,7], shown in the above BST.
Please notice that another valid answer is [5,2,6,null,4,null,7] and it's also accepted.

Example 2:

Input: root = [5,3,6,2,4,null,7], key = 0
Output: [5,3,6,2,4,null,7]
Explanation: The tree does not contain a node with value = 0.*/
    public class Delete_Node_in_a_BST二叉搜索树删除元素 {
        public TreeNode DeleteNode(TreeNode root, int key) {
            // 没有找到目标node
            if(root == null)
            {
                return null;
                //  节点左右都有null，直接删掉
            }
            if(root.Val == key)
            {
                if(root.Left == null && root.Right == null)
                {
                    return null;
                }
                // 左为空，右不为空
                else if(root.Left != null && root.Right == null)
                {
                    return root.Left;
                }else if(root.Left == null && root.Right != null)
                {
                    return root.Right;
                }
                // left和right都不为空
                else
                {
                    var cur = root.Right;
                    while(cur.Left != null)
                    {
                        cur = cur.Left;
                    }
                    cur.Left = root.Left;
                    return root.Right;
                }
            }

            // 单次遍历

            if(root.Val > key)
            {
                root.Left = DeleteNode(root.Left, key);
            }

            if(root.Val < key)
            {
                root.Right = DeleteNode(root.Right, key);
            }

            var linkedList = new LinkedList<string>();
            var linkedListFirst = linkedList.First;
            var value = linkedListFirst.Value;
            return root;
        }
    }
}