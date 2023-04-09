using System;
using System.Collections.Generic;
using System.Linq;
using BinaryTree;

namespace DynamicPrograming.打家劫舍
{
    /*https://leetcode.cn/problems/house-robber-ii/*/
    public class House_Robber_II打家劫舍2
    {
        // 树形dp
        public int Rob(TreeNode root) {
            var result = getRobFrom(root);
            return Math.Max(result[0], result[1]);
        }

        // dp[0] 偷的最大值， dp[1]不偷的最大值
        int[] getRobFrom(TreeNode root)
        {
            if(root == null)
            {
                return new int [] {0, 0};
            }

            // 计算当前节点偷还是不偷

            var left = getRobFrom(root.Left);
            var right = getRobFrom(root.Right);

            var curSteal = root.Val + left[1] + right[1];
            var noSteal = Math.Max(left[0], left[1]) + Math.Max(right[0], right[1]);

            return new int []{curSteal, noSteal};
        }
    }
}