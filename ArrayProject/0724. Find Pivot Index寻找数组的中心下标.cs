using System.Linq;

namespace ArrayProject
{
    /*https://leetcode.cn/problems/find-pivot-index/description/*/
    public class Find_Pivot_Index寻找数组的中心下标 {
        public int PivotIndex(int[] nums) {
            var leftSum = 0;
            var rightSum = nums.Sum();
            for(var i = 0; i < nums.Length; i++)
            {
                rightSum -= nums[i];
                if(leftSum == rightSum)
                {
                    return i;
                }
                leftSum += nums[i];
            }
            return -1;
        }
    }
}