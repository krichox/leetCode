using System;
using System.Collections.Generic;

namespace BinaryTree
{
    /*Given the root of a binary tree, determine if it is a valid binary search tree (BST).

    A valid BST is defined as follows:

    The left 
    subtree
    of a node contains only nodes with keys less than the node's key.
    The right subtree of a node contains only nodes with keys greater than the node's key.
    Both the left and right subtrees must also be binary search trees.
    
    Input: root = [2,1,3]
    Output: true
    
    Input: root = [5,1,4,null,null,3,6]
    Output: false
    Explanation: The root node's value is 5 but its right child's value is 4.
    */
    
    public class Validate_Binary_Search_Tree验证二叉搜素树 {
        public TreeNode preNode = null;
        public bool IsValidBST(TreeNode root) {
            if(root == null)
            {
                return true;
            }
            
            // 中序遍历BST二叉搜索树一定是升序的，所以定义pre，当前节点一定是大于前一个节点的
            var leftNode = IsValidBST(root.Left);
            if(preNode != null && preNode.Val >= root.Val )
            {
                return false;
            }
            // 记录前一个节点
            preNode = root;
            var rightNode = IsValidBST(root.Right);
            return leftNode && rightNode;
        }
        
        public bool IsValidBST2(TreeNode root) {
            var result = new List<int>();
            var stack = new Stack<TreeNode>();
            if(root == null)
            {
                return true;
            }
            var cur = root;
            while(cur != null || stack.Count != 0)
            {
                if(cur != null)
                {
                    stack.Push(cur);
                    cur = cur.Left;
                }
                else
                {
                    cur = stack.Pop();
                    result.Add(cur.Val);
                    cur = cur.Right;
                }
            }

            for(var i = 0; i < result.Count - 1; i++)
            {
                if(result[i] >= result[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}