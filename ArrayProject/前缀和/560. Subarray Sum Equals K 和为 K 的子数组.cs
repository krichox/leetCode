using System.Collections.Generic;

namespace ArrayProject.前缀和
{
    /*https://leetcode.cn/problems/subarray-sum-equals-k/description/?show=1*/
    public class Subarray_Sum_Equals_K_和为_K_的子数组 {
        public int SubarraySum(int[] nums, int k) {
            var len = nums.Length;
            var result = 0;
            var dic = new Dictionary<int, int>();
            dic.Add(0 , 1);
            var preSum = 0;

            for(var i = 0; i< len; i++)
            {
                preSum += nums[i];

                if(dic.ContainsKey(preSum - k))
                {
                    result += dic[preSum - k];
                }
                
                dic[preSum] =  dic.GetValueOrDefault(preSum , 0) + 1;
            }
            // for(var i = 0; i < len; i++)
            // {
            //     preSum[i + 1] = preSum[i] + nums[i];

            // }

            // O(n^2)
            // for(var i = 0; i < len; i++)
            // {
            //     for(var j = i; j < len; j++)
            //     {
            //         if(preSum[j + 1] - preSum[i] == k)
            //         {
            //             result++;
            //         }
            //     }
            // }

            return result;

        }
    }
}