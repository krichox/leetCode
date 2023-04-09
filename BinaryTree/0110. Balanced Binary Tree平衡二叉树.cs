using System;

namespace BinaryTree
{
    /*https://leetcode.cn/problems/balanced-binary-tree/*/
/*Given a binary tree, determine if it is height-balanced.
 
For this problem, a height-balanced binary tree is defined as:
a binary tree in which the left and right subtrees of every node differ in height by no more than 1.

Example 1:
Input: root = [3,9,20,null,null,15,7]
Output: true
Example 2:

Input: root = [1,2,2,3,3,null,null,4,4]
Output: false
Example 3:

Input: root = []
Output: true*/
    public class 高度平衡二叉树
    {
        public bool IsBalanced(TreeNode root)
        {
            return getHeight(root) != -1;
        }

        private int getHeight(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            var left = getHeight(node.Left);
            if (left == -1)
            {
                return -1;
            }

            // 判断左边是否是平衡二叉树
            var right = getHeight(node.Right);
            if (right == -1)
            {
                return -1;
            }

            if (Math.Abs(left - right) > 1)
            {
                return -1;
            }

            return Math.Max(left, right) + 1;
        }
    }
}