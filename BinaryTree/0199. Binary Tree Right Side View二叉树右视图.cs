using System.Collections.Generic;

namespace BinaryTree {}
/*https://leetcode.cn/problems/binary-tree-Right-side-view/*/


/*Given the root of a binary tree, imagine yourself standing on the Right side of it, return the Values of the nodes you can see ordered from top to bottom.

Example 1:
Input: root = [1,2,3,null,5,null,4]
Output: [1,3,4]
Example 2:

Input: root = [1,null,3]
Output: [1,3]
Example 3:

Input: root = []
Output: []*/
public class 二叉树右视图 {
    public IList<int> RightSideView(TreeNode root) {
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
            for(var i = 0; i < count; i++)
            {
                var node = queue.Dequeue();
                if(i == count - 1)
                {
                    result.Add(node.Val);
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
        }

        return result;
    }
}