namespace BinaryTree;

/*https://leetcode.cn/problems/binary-tree-preorder-traversal/*/
/*Given the root of a binary tree, return the preorder traversal of its nodes' values.

Example 1:
Input: root = [1,null,2,3]
Output: [1,2,3]
Example 2:

Input: root = []
Output: []
Example 3:

Input: root = [1]
Output: [1]。*/
public class Binary_Tree_Preorder_Traversal前序遍历
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        proorder(root, result);

        return result;
    }
    
    
    public IList<int> PreorderTraversalNew(TreeNode root) {
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
                stack.Pop();
                if(node.Right != null)
                {
                    stack.Push(node.Right);
                }
                if(node.Left != null)
                {
                    stack.Push(node.Left);
                }
                stack.Push(node);
                stack.Push(null);

            }
            else
            {
                // pop出null
                stack.Pop();
                node = stack.Peek();
                stack.Pop();
                result.Add(node.Val);
            }
        }

        return result;
    }
    
    public IList<int> PreorderTraversal迭代(TreeNode root) {
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
            if(node.Right != null)
            {
                stack.Push(node.Right);
            }

            if(node.Left != null)
            {
                stack.Push(node.Left);
            }
        }
        
        return result;
    }

    private void proorder(TreeNode root, List<int> result)
    {
        if (root == null)
        {
            return;
        }

        result.Add(root.Val);
        proorder(root.Left, result);
        proorder(root.Right, result);
    }
}