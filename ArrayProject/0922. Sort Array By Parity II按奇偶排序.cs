namespace Array
{
    /*https://leetcode.cn/problems/sort-array-by-parity-ii/description/*/
    public class Sort_Array_By_Parity_II按奇偶排序 {
        public int[] SortArrayByParityII(int[] nums) {
            var oddIndex = 1;
            var n = nums.Length;
            for(var i = 0; i < n; i += 2)
            {
                if(nums[i] % 2 == 1)
                {
                    // 找到第一个可以交换的奇数
                    while(nums[oddIndex] % 2 != 1)
                    {
                        oddIndex += 2;
                    }

                    (nums[i], nums[oddIndex]) = (nums[oddIndex], nums[i]);
                }
            }

            return nums;
        }
    }
}