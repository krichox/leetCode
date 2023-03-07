namespace BinaryTree
{
    /*https://leetcode.cn/problems/lowest-common-ancestor-of-a-binary-tree/
     Given a binary tree, find the lowest common ancestor (LCA) of two given nodes in the tree.

According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q as the lowest node in T that has both p and q as descendants (where we allow a node to be a descendant of itself).”
     */
    public class Lowest_Common_Ancestor_of_a_Binary_Tree二叉树最小公共祖先 {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
            // 确认终止条件

            if(root == null || root == p || root == q)
            {
                return root;
            }

            // 单次遍历
            var left = LowestCommonAncestor(root.Left, p, q);
            var right = LowestCommonAncestor(root.Right,p, q);
        
            if(left == null && right == null)
            {
                return null;
            }
            else if(left == null && right != null)
            {
                return right;
            }
            else if(left != null && right == null)
            {
                return left;
            }else 
            {
                return root;
            }
        }
    }
}