using System;
using System.Collections.Generic;

namespace BinaryTree {}

/*https://leetcode.cn/problems/average-of-levels-in-binary-tree/*/
/*Given the root of a binary tree, return the average value of the nodes on each level in the form of an array. Answers within 10-5 of the actual answer will be accepted.

Example 1:
Input: root = [3,9,20,null,null,15,7]
Output: [3.00000,14.50000,11.00000]
Explanation: The average value of nodes on level 0 is 3, on level 1 is 14.5, and on level 2 is 11.
Hence return [3, 14.5, 11].
Example 2:
Input: root = [3,9,20,15,7]
Output: [3.00000,14.50000,11.00000]*/
public class 层次遍历平均值 {
    public IList<double> AverageOfLevels(TreeNode root) {
        var result = new List<Double>();
        if(root == null)
        {
            return result;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count != 0)
        {
            double sum = 0;
            var count = queue.Count;
            for(var i = 0; i < count; i++)
            {
                var node = queue.Dequeue();
                sum += node.Val;
                if(node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if(node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
            
            result.Add(sum / count);
        }

        return result;
    } 
}