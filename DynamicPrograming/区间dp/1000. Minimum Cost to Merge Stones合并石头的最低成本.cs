using System;

namespace DynamicPrograming.区间dp
{
    /*https://leetcode.cn/problems/minimum-cost-to-merge-stones/description/*/
    public class Minimum_Cost_to_Merge_Stones合并石头的最低成本
    {
        // dfs
        int k;

        int[] s;

        // 从i到j合并成k堆所需要的最小花费
        int[][] memo;
        int[,] f;

        public int MergeStones(int[] stones, int k)
        {
            this.k = k;
            var n = stones.Length;
            if ((n - 1) % (k - 1) > 0)
            {
                return -1;
            }

            s = new int[n + 1];
            // 数组前缀和
            for (var i = 0; i < n; i++)
            {
                s[i + 1] = s[i] + stones[i];
            }

            memo = new int[n][];
            for (var i = 0; i < n; i++)
            {
                memo[i] = new int[n];
                Array.Fill(memo[i], -1);
            }

            return dfs(0, n - 1);

        }

        // i <= j
        private int dfs(int i, int j)
        {
            // 边界条件, 只有一堆石子
            if (i == j)
            {
                return 0;
            }

            if (memo[i][j] != -1)
            {
                return memo[i][j];
            }

            var res = int.MaxValue;

            // 枚举堆
            for (var m = i; m < j; m += k - 1)
            {
                res = Math.Min(res, dfs(i, m) + dfs(m + 1, j));
            }

            if ((j - i) % (k - 1) == 0)
            {
                res += s[j + 1] - s[i];
            }

            return memo[i][j] = res;
        }

        public int MergeStones2(int[] stones, int k)
        {
            this.k = k;
            var n = stones.Length;
            if ((n - 1) % (k - 1) > 0)
            {
                return -1;
            }

            f = new int[n, n];
            s = new int[n + 1];
            // 数组前缀和
            for (var i = 0; i < n; i++)
            {
                s[i + 1] = s[i] + stones[i];
            }

            for (var i = n - 1; i >= 0; i--)
            {
                for (var j = i + 1; j < n; j++)
                {
                    f[i, j] = int.MaxValue;
                    for (var m = i; m < j; m += k - 1)
                    {
                        f[i, j] = Math.Min(f[i, j], f[i, m] + f[m + 1, j]);
                    }

                    if ((j - i) % (k - 1) == 0)
                    {
                        f[i, j] += s[j + 1] - s[i];
                    }
                }
            }

            return f[0, n - 1];
        }
    }
}