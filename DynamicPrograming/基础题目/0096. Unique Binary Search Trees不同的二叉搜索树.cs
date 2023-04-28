namespace DynamicPrograming._1
{
    /*https://leetcode.cn/problems/unique-binary-search-trees/description/*/
    public class Unique_Binary_Search_Trees不同的二叉搜索树 {
        public int NumTrees(int n) {
            var dp = new int[n + 1];
        
            dp[0] = 1;


            for(var i = 1; i <= n; i++)
            {
                for(var j = 1; j <= i; j++)
                {
                    // 左子树加右子树的可能性
                    dp[i] += dp[j - 1] * dp[i - j];
                }
            }

            return dp[n];
        }
    }
}