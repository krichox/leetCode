namespace ArrayProject.前缀和
{
    /*https://leetcode.cn/problems/range-sum-query-immutable/description/*/
    public class NumArray {
        int[] preSum;
        public NumArray(int[] nums) {
            preSum = new int[nums.Length + 1];
            for(var i = 0; i < nums.Length; i++)
            {
                preSum[i + 1] = preSum[i] + nums[i];
            }
        }
    
        public int SumRange(int left, int right) {
            return preSum[right + 1] - preSum[left];
        }
    }
}