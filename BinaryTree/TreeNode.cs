namespace BinaryTree
{
    public class TreeNode
    {
        public TreeNode Left;

        public TreeNode Right;

        public int Val;

        public TreeNode(int val, TreeNode left = null, TreeNode right = null)
        {
            this.Val = val;
            this.Left = left;
            this.Right = right;
        }
    }
}