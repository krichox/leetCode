using System.Collections.Generic;
using System.Linq;

namespace BinaryTree
{
    /*https://leetcode.cn/problems/path-sum/*/
/*Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path such that adding up all the Values along the path equals targetSum.

A leaf is a node with no children.

Example 1:

Input: root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
Output: true
Explanation: The root-to-leaf path with the target sum is shown.
Example 2:

Input: root = [1,2,3], targetSum = 5
Output: false
Explanation: There two root-to-leaf paths in the tree:
(1 --> 2): The sum is 3.
(1 --> 3): The sum is 4.
There is no root-to-leaf path with sum = 5.
Example 3:

Input: root = [], targetSum = 0
Output: false
Explanation: Since the tree is empty, there are no root-to-leaf paths.*/
    public class 路径之和 {
        private bool isExistSum;
        public bool HasPathSum(TreeNode root, int targetSum) {
            var paths = new List<int>();
            getTreeSum(root, paths, targetSum);
            return isExistSum;
        }

        private void getTreeSum(TreeNode root, List<int> paths, int targetSum)
        {
            if(root == null)
            {
                return;
            }
            paths.Add(root.Val);


            getTreeSum(root.Left, paths, targetSum);
            getTreeSum(root.Right, paths, targetSum);

            if(root.Left == null && root.Right == null &&  paths.Sum() == targetSum)
            {
                isExistSum = true; 
            }else
            {
                paths.RemoveAt(paths.Count - 1);
            }

        }
    
        public bool HasPathSum简介版本(TreeNode root, int targetSum) {
            return getTreeSum(root, targetSum);
        }

        private bool getTreeSum(TreeNode root, int targetSum)
        {
            if(root == null)
            {
                return false;
            }

            targetSum -= root.Val;

            if(root.Left == null && root.Right == null )
            {
                return targetSum == 0;
            }

            return getTreeSum(root.Left, targetSum) || getTreeSum(root.Right, targetSum);
        }   
    }
}