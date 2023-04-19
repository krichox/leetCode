using System;

namespace BinaryTree
{
    /*https://leetcode.cn/problems/maximum-difference-between-node-and-ancestor/submissions/425806269/*/
    public class 节点与其祖先之间的最大差值 {
        private int ans = int.MinValue;
        public int MaxAncestorDiff(TreeNode root) {
            // dfs的话，一定是父子节点
            GetMaxAncestorDiff(root, root.Val, root.Val);

            return ans;
        }

        void GetMaxAncestorDiff(TreeNode root, int max, int min)
        {
            if(root == null)
            {
                return;
            }
            max = Math.Max(root.Val, max);
            min = Math.Min(root.Val, min);
            ans = Math.Max(ans, max - min);
            GetMaxAncestorDiff(root.Left, max, min);
            GetMaxAncestorDiff(root.Right,max, min);
        }
    }
}