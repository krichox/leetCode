using System;

namespace BinaryTree
{
    /*Given the root of a Binary Search Tree (BST), return the minimum absolute difference between the values of any two different nodes in the tree.*/
    public class MinimumAbsoluteDifferenceInBst二叉搜索树的最小绝对差
    {
        TreeNode pre = null;
        int _minAbs = int.MaxValue;
        int _curAbs = 0;

        public int GetMinimumDifference(TreeNode root)
        {
            FindAbsIn(root);

            return _minAbs;
        }

        private void FindAbsIn(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            FindAbsIn(root.Left);
            var curVal = root.Val;
            if (pre != null)
            {
                _curAbs = Math.Abs(curVal - pre.Val);
            }

            if (pre != null && _curAbs < _minAbs)
            {
                _minAbs = _curAbs;
            }

            pre = root;

            FindAbsIn(root.Right);
        }
    }
}