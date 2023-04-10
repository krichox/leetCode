using System.Collections.Generic;

namespace BinaryTree
{
    /*https://leetcode.cn/problems/search-in-a-binary-search-tree/*/
/*You are given the root of a binary search tree (BST) and an integer val.

Find the node in the BST that the node's value equals val and return the subtree rooted with that node. If such a node does not exist, return null.

Example 1:
Input: root = [4,2,7,1,3], val = 2
Output: [2,1,3]
Example 2:
Input: root = [4,2,7,1,3], val = 5
Output: []*/
    public class 二叉搜索树中的搜索 {
    
        public TreeNode SearchBSTNew(TreeNode root, int val) {
            if(root == null || root.Val == val)
            {
                return root;
            }

            if(val < root.Val)
            {
                return  SearchBST(root.Left, val);
            }else
            {
                return  SearchBST(root.Right, val);
            }
        }
    
    
        public TreeNode searchBST(TreeNode root, int val) {
            if (root == null || root.Val == val) {
                return root;
            }
            var stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count != 0) {
                TreeNode pop = stack.Pop();
                if (pop.Val == val) {
                    return pop;
                }
                if (pop.Right != null) {
                    stack.Push(pop.Right);
                }
                if (pop.Left != null) {
                    stack.Push(pop.Left);
                }
            }
        
            return null;
        }
    
    
    
    
    
        private TreeNode point;
        public TreeNode SearchBST(TreeNode root, int val) {
            getTargetTree(root, val);
            return point;
        }
        private void getTargetTree(TreeNode root, int val)
        {
            if(root == null)
            {
                return;
            }

            if(root.Val == val)
            {
                point = root;
                return;
            }

            getTargetTree(root.Left, val);
            getTargetTree(root.Right, val);
        }
    
    
    
    }
}