using System.Collections.Generic;

namespace BinaryTree
{
    /*https://leetcode.cn/problems/find-largest-value-in-each-tree-row/*/
/*Given the root of a binary tree, return an array of the largest value in each row of the tree (0-indexed).

Example 1:
Input: root = [1,3,2,5,3,null,9]
Output: [1,3,9]
Example 2:

Input: root = [1,2,3]
Output: [1,3]*/
    public class 在每个树行中找最大值 {
        public IList<int> LargestValues(TreeNode root) {
            var result = new List<int>();
            if(root == null)
            {
                return result;
            }
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while(queue.Count != 0)
            {
                var count = queue.Count;
                var max = queue.Peek().Val;
                for(var i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    if(node.Val > max)
                    {
                        max = node.Val;
                    }

                    if(node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }

                    if(node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }

                result.Add(max);
            }

            return result;
        }
    }
}