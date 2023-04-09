using System;
using System.Collections.Generic;

namespace DynamicPrograming.状压
{
    /*https://leetcode.cn/problems/smallest-sufficient-team/description/*/
    /*把 people[i] 看成物品（集合），reqSkills 看成背包容量（目标集合），本题就是一个集合版本的 0-1 背包问题*/
    public class Smallest_Sufficient_Team最小的必要团队
    {
        private int[] mask;
        private long all;
        private long[][] memo;
        public int[] SmallestSufficientTeam(string[] req_skills, IList<IList<string>> people)
        {
            Dictionary<string, int> requestSkillDic = new();
            int m = req_skills.Length;
            int n = people.Count;
            for (var i = 0; i < req_skills.Length; i++)
            {
                requestSkillDic.Add(req_skills[i], i);
            }
            mask = new int[n];

            for (var i = 0; i < people.Count; i++)
            {
                foreach (var perPeople in people[i])
                {
                    mask[i] |= 1 << requestSkillDic[perPeople];
                }
            }

            var u = 1 << m;

            memo = new long[n][];
            for (var i = 0; i < memo.Length; i++)
            {
                memo[i] = new long[u];
                Array.Fill(memo[i], - 1);
            }
            // 所有people全选
            all = (1L << n) - 1;

            long res = dfs(n - 1, u - 1);

            var ans = new int[bitCount(res)];
            for (int i = 0, j = 0; i < n; i++)
            {
                if (((res >> i) & 1) > 0)
                {
                    ans[j++] = i;
                }
            }

            return ans;

        }
        public int[] SmallestSufficientTeam2(string[] req_skills, IList<IList<string>> people)
        {
            Dictionary<string, int> requestSkillDic = new();
            int m = req_skills.Length;
            int n = people.Count;
            for (var i = 0; i < req_skills.Length; i++)
            {
                requestSkillDic.Add(req_skills[i], i);
            }
            mask = new int[n];
            var u = 1 << m;
            var dp = new long[n + 1, u];



            memo = new long[n][];
            for (var i = 0; i < memo.Length; i++)
            {
                memo[i] = new long[u];
                Array.Fill(memo[i], - 1);
            }
            // 所有people全选
            all = (1L << n) - 1;

            long res = dfs(n - 1, u - 1);

            var ans = new int[bitCount(res)];
            for (int i = 0, j = 0; i < n; i++)
            {
                if (((res >> i) & 1) > 0)
                {
                    ans[j++] = i;
                }
            }

            return ans;

        }
        
        
        
        // 从前i个元素选择某些元素，构成j，至少需要选择几个元素
        /*dfs(i,j) 定义成从前 i 个集合中选择一些集合，并集等于 j，所选择的最小下标集合*/
        private long dfs(int i, int j)
        {
            if (j == 0)
            {
                return 0;
            }

            if (i < 0)
            {
                return all;
            }

            if (memo[i][j] != -1)
            {
                return memo[i][j];
            }

            // 不选
            var res = dfs(i - 1, j);
            var res2 = dfs(i - 1, j & ~mask[i]) | (1L << i);
            return memo[i][j] = bitCount(res) < bitCount(res2) ? res : res2;
        }

        private int bitCount(long x)
        {
            var count = 0;
            while (x > 0)
            {
                if ((x & 1) > 0)
                {
                    count++;
                }

                x >>= 1;

            }

            return count;
        }
    }
}