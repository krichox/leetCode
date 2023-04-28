using System;
using System.Linq;

namespace DynamicPrograming.背包dp
{
    /*https://leetcode.cn/problems/partition-equal-subset-sum/*/
    public class Partition_Equal_Subset_Sum分割等和子集 {
        
        /*背包的体积为sum / 2
        背包要放入的商品（集合里的元素）重量为 元素的数值，价值也为元素的数值
        背包如何正好装满，说明找到了总和为 sum / 2 的子集。
        背包中每一个元素是不可重复放入。*/
        public bool CanPartition(int[] nums) {
            // 明确dp含义, 重量为j时，dp放进去的最大值
            // weight[j] 本题其实也是nums[i]
            var dp = new int[10001];
            var sum = nums.Sum() ;
            if(sum % 2 == 1)
            {
                return false;
            }
            var target = sum / 2;
            dp[0] = 0;

            // 物品
            for(var i = 0; i < nums.Length; i++)
            {
                // 背包/重量
                for(var j = target; j >= nums[i]; j--)
                {
                    dp[j] = Math.Max(dp[j], dp[j- nums[i]] + nums[i]);
                }
            }

            if(dp[target] == target)
            {
                return true;
            }

            return false;

        }
    }
}