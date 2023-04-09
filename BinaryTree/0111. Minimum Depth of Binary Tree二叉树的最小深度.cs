using System;
using System.Collections.Generic;

namespace BinaryTree
{
    /*https://leetcode.cn/problems/minimum-depth-of-binary-tree/*/
/*Given a binary tree, find its minimum depth.

The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.

Note:A leaf is a node with no children.
Example 1:
Input: root = [3,9,20,null,null,15,7]
Output: 2
Example 2:

Input: root = [2,null,3,null,4,null,5,null,6]
Output: 5*/
    public class 二叉树的最小深度
    {
        public int MinDepth(TreeNode root)
        {
            var result = 0;
            if (root == null)
            {
                return result;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var count = queue.Count;
                result++;
                for (var i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();

                    if (node.Left == null && node.Right == null)
                    {
                        return result;
                    }

                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }

                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }
            }

            return result;
        }

        public int MinDepth2(TreeNode root)
        {
            return getMinDepth(root);
        }

        public int getMinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var Left = getMinDepth(root.Left);
            var Right = getMinDepth(root.Right);

            if (root.Left == null && root.Right != null)
            {
                return 1 + Right;
            }

            if (root.Left != null && root.Right == null)
            {
                return 1 + Left;
            }

            return Math.Min(Left, Right) + 1;
        }
    }
}