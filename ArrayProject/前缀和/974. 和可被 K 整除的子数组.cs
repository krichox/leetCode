using System.Collections.Generic;

namespace ArrayProject.前缀和
{
    public class 和可被_K_整除的子数组 {
        public int SubarraysDivByK(int[] nums, int k) {
            // 定义前缀和
            var preNumsDic = new Dictionary<int, int>();
            preNumsDic[0] = 1;
            var preSum = 0;
            var res = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                preSum += nums[i];
                var cur = (preSum % k + k) % k;
                if(preNumsDic.ContainsKey(cur))
                {
                    res += preNumsDic[cur];
                }
                preNumsDic[cur] = preNumsDic.GetValueOrDefault(cur, 0) + 1;
            }

            return res;
        }
    }
}