namespace ArrayProject.前缀和
{
    /*https://leetcode.cn/problems/count-number-of-nice-subarrays/description/*/
    public class 统计_优美子数组_ {
        public int NumberOfSubarrays(int[] nums, int k) {
            // 定义前缀奇数和数组,数组下标表示奇数个数，值表示个数
            var preOddSum = new int[nums.Length + 1];
        
            preOddSum[0] = 1;
            var oddNum = 0;
            var res = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                oddNum += nums[i] & 1;
                preOddSum[oddNum]++;
                if(oddNum >= k)
                {
                    res += preOddSum[oddNum - k];
                }
            }
            return res;
        }
    }
}