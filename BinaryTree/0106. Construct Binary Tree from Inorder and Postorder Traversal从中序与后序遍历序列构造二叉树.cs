namespace BinaryTree {}

/*https://leetcode.cn/problems/construct-binary-tree-from-inorder-and-postorder-traversal/*/
/*Given two integer arrays inorder and postorder where inorder is the inorder traversal of a binary tree and postorder is the postorder traversal of the same tree, construct and return the binary tree.

Example 1:
Input: inorder = [9,3,15,20,7], postorder = [9,15,7,20,3]
Output: [3,9,20,null,null,15,7]
Example 2:

Input: inorder = [-1], postorder = [-1]
Output: [-1]*/
/*来看一下一共分几步：

第一步：如果数组大小为零的话，说明是空节点了。

第二步：如果不为空，那么取后序数组最后一个元素作为节点元素。

第三步：找到后序数组最后一个元素在中序数组的位置，作为切割点

第四步：切割中序数组，切成中序左数组和中序右数组 （顺序别搞反了，一定是先切中序数组）

第五步：切割后序数组，切成后序左数组和后序右数组

第六步：递归处理左区间和右区间*/

public class 从中序与后序遍历序列构造二叉树
{
    private Dictionary<int, int> dic;
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        dic = new Dictionary<int, int>();
        for(var i = 0; i < inorder.Length; i++)
        {
            dic[inorder[i]] = i;
        }
        return findNode(inorder, 0, inorder.Length, postorder, 0, postorder.Length);

    }

    private TreeNode findNode(int[] inorder, int inBegin, int inEnd, int[] postorder, int postBegin, int postEnd)
    {
        // 左闭右开
        if(inBegin >= inEnd || postBegin >= postEnd)
        {
            return null;
        }

        // 获取root在中序的index
        var midIndex = dic[postorder[postEnd - 1]];
        var root = new TreeNode(val: inorder[midIndex], left: null, right: null);
        // 中到左到距离
        var lenOfLeft = midIndex - inBegin;
        root.Left = findNode(inorder, inBegin, midIndex, postorder, postBegin, postBegin + lenOfLeft);
        root.Right = findNode(inorder, midIndex + 1, inEnd, postorder, postBegin + lenOfLeft, postEnd - 1);

        return root;
    }
}