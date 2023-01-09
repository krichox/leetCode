using System.Text;

namespace BinaryTree;

/*https://leetcode.cn/problems/binary-tree-paths/*/
/*Given the root of a binary tree, return all root-to-leaf paths in any order.

A leaf is a node with no children.
Example 1:
Input: root = [1,2,3,null,5]
Output: ["1->2->5","1->3"]
Example 2:

Input: root = [1]
Output: ["1"]*/
public class 二叉树路径
{
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        var result = new List<String>();
        if (root == null)
        {
            return result;
        }

        var path = new List<int>();

        dfsBinaryTree(root, path, result);

        return result;
    }

    private void dfsBinaryTree(TreeNode root, List<int> path, List<String> result)
    {
        // 添加路径
        path.Add(root.Val);

        // 终止条件: 左右node都为空,添加到result里面
        if (root.Left == null && root.Right == null)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < path.Count - 1; i++)
            {
                sb.Append(path[i]).Append("->");
            }

            sb.Append(path[path.Count - 1]);
            result.Add(sb.ToString());
            return;
        }

        if (root.Left != null)
        {
            dfsBinaryTree(root.Left, path, result);
            path.RemoveAt(path.Count - 1);
        }

        if (root.Right != null)
        {
            dfsBinaryTree(root.Right, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }
}