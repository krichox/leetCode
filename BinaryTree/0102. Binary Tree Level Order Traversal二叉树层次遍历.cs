using System.Collections.Generic;

namespace BinaryTree {}

/*https://leetcode.cn/problems/binary-tree-level-order-traversal/*/
/*Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from Left to Right, level by level).

Example 1:
Input: root = [3,9,20,null,null,15,7]
Output: [[3],[9,20],[15,7]]
Example 2:

Input: root = [1]
Output: [[1]]
Example 3:

Input: root = []
Output: []*/
public class 二叉树层次遍历
{
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        if(root == null)
        {
            return result;
        }
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count != 0)
        {
            var list = new List<int>();
            var count = queue.Count;
            for(var i = 0; i < count; i++)
            {
                var node = queue.Dequeue();
                list.Add(node.Val);

                if(node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }
                if(node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
            
            result.Add(list);
        }
        
        return result;
    }
}