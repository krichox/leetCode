using System;

namespace BinaryTree
{
    /*https://leetcode.cn/problems/maximum-depth-of-binary-tree/*/
/*Given the root of a binary tree, return its maximum depth.

A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

Example 1:
Input: root = [3,9,20,null,null,15,7]
Output: 3
Example 2:

Input: root = [1,null,2]
Output: 2*/
    public class 二叉树的最大深度
    {
        public int MaxDepth(TreeNode root)
        {
            return getMaxDepth(root);
        }

        public int getMaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var left = getMaxDepth(root.Left);
            var right = getMaxDepth(root.Right);
            return Math.Max(left, right) + 1;
        }
    }
}