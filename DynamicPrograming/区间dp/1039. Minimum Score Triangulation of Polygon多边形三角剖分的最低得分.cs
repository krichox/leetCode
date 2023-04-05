using System;

namespace DynamicPrograming.区间dp
{
    /*https://leetcode.cn/problems/minimum-score-triangulation-of-polygon/description/*/
    public class Minimum_Score_Triangulation_of_Polygon多边形三角剖分的最低得分 {
        int[][] memo;  
        public int MinScoreTriangulation(int[] values) {
            memo = new int[values.Length][];
            // 初始化
            for(var i = 0; i < memo.Length; i++)
            {
                memo[i] = new int[values.Length];
                Array.Fill(memo[i], -1);
            }

            return  dfs(0, values.Length, values);
        }

        private int dfs(int i, int j, int[] values)
        {
            
            // 边界值，终止条件，只有两个点则返回0
            if(i + 1 == j)
            {
                return 0;
            }

            if(memo[i][j] != -1)
            {
                return memo[i][j];
            }
            var res = int.MaxValue;
            for(var k = i + 1; k < j; k++)
            {

                res = Math.Max(res, dfs(i, k,values) +dfs(k, j,values) + values[i] * values[j] * values[k]);
            }

            return res;

        }

        public int MinScoreTriangulation2(int[] values)
        {
            // 动态规划
            var n = values.Length;
            var dp = new int[n, n];
            for (var i = n - 3; i >= 0; i--)
            {
                for (var j = i + 2; j < n; j++)
                {
                    dp[i, j] = int.MaxValue;
                    for (var k = i + 1; k < j; k++)
                    {
                        dp[i, j] = Math.Min(dp[i, j], dp[i, k] + dp[k, j] + values[i] * values[k] * values[j]);
                    }
                }
            }

            return dp[0, n - 1];
        }
    }
}