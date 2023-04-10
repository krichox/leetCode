using System.Collections.Generic;

namespace BinaryTree
{
    /*https://leetcode.cn/problems/construct-binary-tree-from-preorder-and-inorder-traversal/*/
/*Given two integer arrays preorder and inorder where preorder is the preorder traversal of a binary tree and inorder is the inorder traversal of the same tree, construct and return the binary tree.

Example 1:
Input: preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]
Output: [3,9,20,null,null,15,7]
Example 2:

Input: preorder = [-1], inorder = [-1]
Output: [-1]*/
    public class 从前序与中序遍历序列构造二叉树
    {
        private Dictionary<int, int> dic;

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            dic = new Dictionary<int, int>();
            // 添加到dic里去
            for (var i = 0; i < inorder.Length; i++)
            {
                dic[inorder[i]] = i;
            }

            return getNode(inorder, 0, inorder.Length, preorder, 0, preorder.Length);
        }

        private TreeNode getNode(int[] inorder, int inBegin, int inEnd, int[] preorder, int preBegin, int preEnd)
        {
            // 结束条件
            if (preBegin >= preEnd || inBegin >= inEnd)
            {
                return null;
            }

            // 找到root节点
            var rootIndex = dic[preorder[preBegin]];
            // 中序左子树个数
            var lenOfLeft = rootIndex - inBegin;
            var root = new TreeNode(val: inorder[rootIndex], left: null, right: null);
            root.Left = getNode(inorder, inBegin, rootIndex, preorder, preBegin + 1, preBegin + lenOfLeft + 1);
            root.Right = getNode(inorder, rootIndex + 1, inEnd, preorder, preBegin + lenOfLeft + 1, preEnd);

            return root;
        }
    }
}