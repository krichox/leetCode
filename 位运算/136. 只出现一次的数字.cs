namespace OtherProject
{
    /*https://leetcode.cn/problems/single-number/description/*/
    public class 只出现一次的数字 {
        //a ^ 0 = a , a ^ a = 0
        public int SingleNumber(int[] nums) {
            var res = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                res ^= nums[i];
            }
            return res;
        }
    }
}