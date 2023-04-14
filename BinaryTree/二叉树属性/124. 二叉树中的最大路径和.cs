using System;

namespace BinaryTree
{
    /*https://leetcode.cn/problems/binary-tree-maximum-path-sum/description/*/
    public class 二叉树中的最大路径和 {
        int max = int.MinValue;
        public int MaxPathSum(TreeNode root) {
            FindMaxPathSum(root);
            return max;;
        
        }
        public int FindMaxPathSum(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }
        
            var left = Math.Max(0, FindMaxPathSum(root.Left));
            var right = Math.Max(0,FindMaxPathSum(root.Right));
        
            var allChoseValue = root.Val + left + right;
            var choseTwoMax = Math.Max(root.Val + left, root.Val + right);
        
        
            if(allChoseValue > max)
            {
                max = allChoseValue;
            }
        
            return choseTwoMax;
        }
    }
}