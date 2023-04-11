using System.Collections.Generic;

namespace BinaryTree
{
    /*https://leetcode.cn/problems/balance-a-binary-search-tree/description/*/
    public class 将二叉搜索树变平衡 {
        IList<int> res = new List<int>();
        public TreeNode BalanceBST(TreeNode root) {
            inOrder(root);

            return BuildBalanceSearchTree(0, res.Count - 1);
        }

        void inOrder(TreeNode root)
        {
            if(root == null)
            {
                return;
            }

            inOrder(root.Left);
            res.Add(root.Val);
            inOrder(root.Right);
        }

        TreeNode BuildBalanceSearchTree(int Left, int Right)
        {
            if(Left > Right)
            {
                return null;
            }

            var mid = Left + (Right - Left) / 2;
            var cur = new TreeNode(res[mid]);

            cur.Left = BuildBalanceSearchTree(Left, mid - 1);
            cur.Right = BuildBalanceSearchTree(mid + 1, Right);

            return cur;
        }
        // 时间复杂度：中序遍历构造数组o(n),  buildBalanceTree O(n)最终是O（n）
        // 空间复杂度: 递归构建logn， 构建数组O(n)所以是O（n）
    }
}