namespace BinaryTree
{
    /*You are given the root node of a binary search tree (BST) and a value to insert into the tree. Return the root node of the BST after the insertion. It is guaranteed that the new value does not exist in the original BST.

Notice that there may exist multiple valid ways for the insertion, as long as the tree remains a BST after insertion. You can return any of them.

Example 1:


Input: root = [4,2,7,1,3], val = 5
Output: [4,2,7,1,3,5]
Explanation: Another accepted tree is:

Example 2:

Input: root = [40,20,60,10,30,50,70], val = 25
Output: [40,20,60,10,30,50,70,null,null,25]
Example 3:

Input: root = [4,2,7,1,3,null,null,null,null,null,null], val = 5
Output: [4,2,7,1,3,5]*/
    public class Insert_into_a_Binary_Search_Tree二叉搜索树插入元素 {
        public TreeNode InsertIntoBST(TreeNode root, int val) {


            // 结束条件，找到null就是找到合适的位置
            if(root == null)
            {
                return new TreeNode(val);
            }

            if(root.Val > val)
            {
                root.Left = InsertIntoBST(root.Left, val);
            }

            if(root.Val < val)
            {
                root.Right = InsertIntoBST(root.Right, val);
            }
        

            return root;
        }
    }
}