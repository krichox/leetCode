namespace BinaryTree {}

/*https://leetcode.cn/problems/sum-of-left-leaves/*/
/*Given the root of a binary tree, return the sum of all left leaves.
A leaf is a node with no children. A left leaf is a leaf that is the left child of another node.

Example 1:

Input: root = [3,9,20,null,null,15,7]
Output: 24
Explanation: There are two left leaves in the binary tree, with values 9 and 15 respectively.
Example 2:

Input: root = [1]
Output: 0*/
public class 左子树之和
{
    public int SumOfLeftLeaves(TreeNode root)
    {
        return dfs(root);
    }

    private int dfs(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        var left = dfs(root.Left);
        var right = dfs(root.Right);
        var minvalue = 0;
        if (root.Left != null && root.Left.Left == null && root.Left.Right == null)
        {
            minvalue = root.Left.Val;
        }

        return minvalue + left + right;
    }
}