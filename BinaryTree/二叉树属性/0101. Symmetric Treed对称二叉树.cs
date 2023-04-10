namespace BinaryTree
{
    /*https://leetcode.cn/problems/symmetric-tree/*/
/*Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).

Example 1:
Input: root = [1,2,2,3,4,4,3]
Output: true
Example 2:
Input: root = [1,2,2,null,3,null,3]
Output: false*/
    public class 对称二叉树
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return dfs(root.Left, root.Right);
        }

        private bool dfs(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }

            if (left == null || right == null)
            {
                return false;
            }

            if (left.Val != right.Val)
            {
                return false;
            }

            return dfs(left.Left, right.Right) && dfs(left.Right, right.Left);
        }
    }
}