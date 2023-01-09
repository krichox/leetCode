namespace LinkedList;

/*https://leetcode.cn/problems/3sum/*/
/*Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets.

Example 1:

Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Explanation: 
nums[0] + nums[1] + nums[1] = (-1) + 0 + 1 = 0.
nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
The distinct triplets are [-1,0,1] and [-1,-1,2].
Notice that the order of the output and the order of the triplets does not matter.

Example 2:
Input: nums = [0,1,1]
Output: []
Explanation: The only possible triplet does not sum up to 0.

Example 3:
Input: nums = [0,0,0]
Output: [[0,0,0]]
Explanation: The only possible triplet sums up to 0.
*/

public class 三数之和
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();
        // 排序
        Array.Sort(nums);

        for (var i = 0; i < nums.Length; i++)
        {
            // i 指针到大于0时,break;
            if (nums[i] > 0)
            {
                return result;
            }

            // 去重
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            var left = i + 1;
            var right = nums.Length - 1;
            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];
                if (sum < 0)
                {
                    left++;
                }
                else if (sum > 0)
                {
                    right--;
                }
                else
                {
                    var res = new int[3] { nums[i], nums[left], nums[right] }.ToList();
                    result.Add(res);
                    
                    // 去除左右重复对元素
                    while (right > left && nums[right] == nums[right - 1])
                    {
                        right--;
                    }

                    while (right > left && nums[left] == nums[left + 1])
                    {
                        left++;
                    }

                    left++;
                    right--;
                }
            }
        }

        return result;
    }
}