namespace BinaryTree
{
    /*https://leetcode.cn/problems/sum-root-to-leaf-numbers/description/*/
    public class Sum_Root_to_Leaf_Numbers求根节点到叶节点数字之和 {
        public int SumNumbers(TreeNode root) {
            return dfs(root, 0);
        }
    
        int dfs(TreeNode root, int preSum)
        {
            if(root == null)
            {
                return 0;
            }

            var sum = preSum * 10 + root.Val;
            if(root.Left == null && root.Right == null)
            {
                return sum;
            }
            else
            {
                return dfs(root.Left, sum) + dfs(root.Right, sum);
            }
        }
    }
}