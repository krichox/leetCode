namespace BinaryTree
{
    /*https://leetcode.cn/problems/count-complete-tree-nodes/*/
/*Given the root of a complete binary tree, return the number of the nodes in the tree.

According to Wikipedia, every level, except possibly the last, is completely filled in a complete binary tree, and all nodes in the last level are as far left as possible. It can have between 1 and 2h nodes inclusive at the last level h.

Design an algorithm that runs in less thanO(n)time complexity.
Example 1:
Input: root = [1,2,3,4,5,6]
Output: 6
Example 2:

Input: root = []
Output: 0
Example 3:

Input: root = [1]
Output: 1*/
    public class 完全二叉树的节点个数
    {
        public int CountNodes(TreeNode root)
        {
            return getNodeCount(root);
        }

        public int getNodeCount(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var left = getNodeCount(root.Left);
            var right = getNodeCount(root.Right);

            return left + right + 1;
        }
    }
}