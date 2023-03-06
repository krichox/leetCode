namespace BinaryTree {}
/*https://leetcode.cn/problems/find-bottom-left-tree-Value/*/
/*Given the root of a binary tree, return the leftmost Value in the last row of the tree.

Example 1:
Input: root = [2,1,3]
Output: 1
Example 2:
Input: root = [1,2,3,4,null,5,6,null,null,7]
Output: 7*/
public class 找树左下角的值 {
    public int FindBottomLeftValue(TreeNode root) {
        var result = 0;
        if(root == null)
        {
            return 0;
        }

        var queue  = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count != 0)
        {
            var count = queue.Count;
            for(var i = 0; i < count; i++)
            {
                var node = queue.Dequeue();
                if(i == 0)
                {
                    result = node.Val;
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
    
    private int Deep = 0;
    private int result = 0;
    public int FindBottomLeftValue递归(TreeNode root) {
        result = root.Val;
        getBottomLeftValue(root, 0);
        return result;
    }

    private void getBottomLeftValue(TreeNode root, int deep)
    {
        if(root == null)
        {
            return;
        }

        if(root.Left == null && root.Right == null)
        {
            if(deep > Deep)
            {
                result = root.Val;
                Deep = deep;
            }
        }

        getBottomLeftValue(root.Left, deep + 1);
        getBottomLeftValue(root.Right, deep + 1);
    }
}