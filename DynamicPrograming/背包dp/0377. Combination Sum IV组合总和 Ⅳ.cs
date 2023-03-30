namespace DynamicPrograming.背包dp
{
    /*https://leetcode.cn/problems/combination-sum-iv/description/*/
    public class Combination_Sum_IV组合总和
    {
        public int CombinationSum4(int[] nums, int target)
        {
            var dp = new int[target + 1];

            dp[0] = 1;

            // 遍历背包
            for (var i = 0; i <= target; i++)
            {
                //  遍历物品
                for (var j = 0; j < nums.Length; j++)
                {
                    if (i - nums[j] >= 0)
                    {
                        dp[i] += dp[i - nums[j]];
                    }

                }
            }

            return dp[target];
        }
    }
}