namespace BinaryTree;

/*https://leetcode.cn/problems/binary-tree-inorder-traversal/*/
/*Given the root of a binary tree, return the inorder traversal of its nodes' values.
Example 1:


Input: root = [1,null,2,3]
Output: [1,3,2]
Example 2:

Input: root = []
Output: []
Example 3:               

Input: root = [1]
Output: [1]。*/
public class 中序遍历 {
    public IList<int> InorderTraversal(TreeNode root) {
        var result = new List<int>();
        inOrder(root, result);
        
        return result;
    }
    
    public IList<int> InorderTraversalNew(TreeNode root) {
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
                stack.Push(node);
                stack.Push(null);
                if(node.Left != null)
                {
                    stack.Push(node.Left);
                }
            }
            else
            {
                // 去除标记null
                stack.Pop();
                result.Add(stack.Pop().Val);
            }
        }
        
        return result;
    }
    
    public IList<int> InorderTraversal迭代(TreeNode root) {
        var result = new List<int>();
        var stack = new Stack<TreeNode>();
        if(root == null)
        {
            return result;
        }
        var cur = root;
        while(cur != null || stack.Count != 0)
        {
            if(cur != null)
            {
                stack.Push(cur);
                cur = cur.Left;
            }
            else
            {
                cur = stack.Pop();
                result.Add(cur.Val);
                cur = cur.Right;
            }
        }

        return result;
    }

    private void inOrder(TreeNode root, List<int> result)
    {
        if(root == null)
        {
            return;
        }
        inOrder(root.Left, result);
        result.Add(root.Val);
        inOrder(root.Right, result);
    }
}