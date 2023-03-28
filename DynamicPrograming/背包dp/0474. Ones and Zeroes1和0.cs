using System;

namespace DynamicPrograming.背包dp
{
    /*https://leetcode.cn/problems/ones-and-zeroes/description/*/
    public class Ones_and_Zeroes1和0 {
        public int FindMaxForm(string[] strs, int m, int n) {
            // dp[i][j] 表示放i个0和j个1重量的背包最多能放几个str
            var dp = new int[m + 1, n + 1];

            // 遍历物品
            dp[0, 0] = 0;
            foreach(var perStr in strs)
            {
                var zeroNums = 0;
                var oneNums = 0;
                foreach(var perChar in perStr)
                {
                    if(perChar == '0')
                    {
                        zeroNums++;
                    }else{
                        oneNums++;
                    }
                }
                // 遍历重量
                for(var i = m; i >= zeroNums; i--)
                {
                    for(var j = n; j >= oneNums; j--)
                    {
                        dp[i,j] = Math.Max(dp[i,j], dp[i - zeroNums, j - oneNums] + 1);
                    }
                }
            }

            return dp[m, n];
        }
    }
}