namespace BinaryTree
{
    /*https://leetcode.cn/problems/lowest-common-ancestor-of-a-binary-search-tree/
     Given a binary search tree (BST), find the lowest common ancestor (LCA) node of two given nodes in the BST.
According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q as the lowest node in T that has both p and q as descendants (where we allow a node to be a descendant of itself).”
Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 8
Output: 6
Explanation: The LCA of nodes 2 and 8 is 6.
Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 4
Output: 2
Explanation: The LCA of nodes 2 and 4 is 2, since a node can be a descendant of itself according to the LCA definition.
     */
    public class Lowest_Common_Ancestor_of_a_Binary_Search_Tree二叉搜索树最近公共祖先 {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {

            if(root.Val> p.Val && root.Val > q.Val)
            {
                return LowestCommonAncestor(root.Left,p, q);
            }
        
            if(root.Val < p.Val && root.Val < q.Val)
            {
                return LowestCommonAncestor(root.Right,p, q);
            }
        
            return root;
        }
    }
}