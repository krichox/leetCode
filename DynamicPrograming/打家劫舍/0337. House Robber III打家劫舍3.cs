using System;
using System.Collections.Generic;

namespace DynamicPrograming.打家劫舍
{
    /*https://leetcode.cn/problems/house-robber-iii/*/
    public class House_Robber_III打家劫舍3 {
        IList<int> list = new List<int>();

        public int Rob(TreeNode root) {
            getListFrom(root);

            var dp = new int[list.Count];
        
            dp[0] = list[0];
            dp[1] = Math.Max(dp[0], list[1]);

            for(var i = 2; i < list.Count; i++)
            {
                dp[i] = Math.Max(dp[i - 2] + list[i], dp[i - 1]);
            }

            return dp[list.Count - 1];
        }

        void getListFrom(TreeNode root)
        {
            if(root == null)
            {
                return;
            }

            getListFrom(root.Left);
            list.Add(root.Val);
            getListFrom(root.Right);
        }
    }
}