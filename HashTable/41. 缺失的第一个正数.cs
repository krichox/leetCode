namespace HashTable
{
    /*https://leetcode.cn/problems/first-missing-positive/description/*/
    public class 缺失的第一个正数 {
        public int FirstMissingPositive(int[] nums) {
            var n = nums.Length;
            // 把nums当作hash表[0..i] 存储[1..N];
            for(var i = 0; i < n; i++)
            {
                // 一直将当前数放到正确的位置(i-> i +1)
                while(nums[i] >= 1 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
                {
                    (nums[i], nums[nums[i] - 1]) = (nums[nums[i] - 1], nums[i]);
                }
            

            }

            for(var i = 0; i < n; i++)
            {
                if(nums[i] != i + 1)
                {
                    return i + 1;
                }
            }

            return n + 1;
        }
    }
}