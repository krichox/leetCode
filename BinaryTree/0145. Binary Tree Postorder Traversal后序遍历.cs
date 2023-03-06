using System.Collections.Generic;

namespace BinaryTree {}

/*https://leetcode.cn/problems/binary-tree-postorder-traversal/*/
/*Given the root of a binary tree, return the postorder traversal of its nodes' values.

Example 1:
Input: root = [1,null,2,3]
Output: [3,2,1]
Example 2:

Input: root = []
Output: []
Example 3:

Input: root = [1]
Output: [1]*/
public class 后序遍历
{
    public IList<int> PostorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        postOrder(root, result);

        return result;
    }
    
    private void postOrder(TreeNode root, List<int> result)
    {
        if (root == null)
        {
            return;
        }

        postOrder(root.Left, result);
        postOrder(root.Right, result);
        result.Add(root.Val);
    }
    
    public IList<int> PostorderTraversalNew(TreeNode root) {
        var result = new List<int>();
        var stack = new Stack<TreeNode>();
        if(root == null)
        {
            return result;
        }
        stack.Push(root);
        while(stack.Count != 0)
        {
            var node = stack.Peek();
            if(node != null)
            {
                // 左右中-> 中右左
                stack.Pop();
                stack.Push(node);
                stack.Push(null);
                if(node.Right != null)
                {
                    stack.Push(node.Right);
                }
                if(node.Left != null)
                {
                    stack.Push(node.Left);
                }
            }else
            {
                // pop null
                stack.Pop();
                result.Add(stack.Pop().Val);
            }
        }

        return result;
    }
    
    public IList<int> PostorderTraversal迭代(TreeNode root) {
        var result = new List<int>();
        var stack = new Stack<TreeNode>();
        if(root == null)
        {
            return result;
        }
        stack.Push(root);
        while(stack.Count != 0)
        {
            var node = stack.Pop();
            result.Add(node.Val);
            if(node.Left != null)
            {
                stack.Push(node.Left);
            }
            if(node.Right != null)
            {
                stack.Push(node.Right);
            }
        }

        result.Reverse();

        return result;
    }
}