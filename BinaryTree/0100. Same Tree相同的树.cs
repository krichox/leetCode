namespace BinaryTree {}

/*https://leetcode.cn/problems/same-tree/*/
/*Given the roots of two binary trees p and q, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

Example 1:

Input: p = [1,2,3], q = [1,2,3]
Output: true
Example 2:

Input: p = [1,2], q = [1,null,2]
Output: false
Example 3:

Input: p = [1,2,1], q = [1,1,2]
Output: false*/
public class 相同的树
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        return sampeTree(p, q);
    }

    private bool sampeTree(TreeNode left, TreeNode right)
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

        return sampeTree(left.Left, right.Left) && sampeTree(left.Right, right.Right);
    }
}