using System;
using System.Collections.Generic;
using System.Linq;

namespace HashTable
{
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
        
        public IList<IList<int>> ThreeSum2(int[] nums) {
            Array.Sort(nums);
        
            // 3数之和，从0开始，target为0
            return nSumTarget(nums, 3, 0, 0);
        }

        public IList<IList<int>> nSumTarget(int[] nums, int n, int start, int target)
        {
            int len = nums.Length;
            var res = new List<IList<int>>();
            // 至少是2数之和且数组大小不应该小于n
            if(n < 2 || len < n)
            {
                return res;
            }
            // 如果是两数之和
            if(n == 2)
            {
                var left = start;
                var right = len - 1;
                while(left < right)
                {
                    var leftValue = nums[left];
                    var rightValue = nums[right];
                    if(nums[left] + nums[right] == target)
                    {
                        res.Add(new List<int>{leftValue, rightValue});
                        // 去重相同元素
                        while(left < right && nums[left] == leftValue )
                        {
                            left++;
                        }
                        while(left < right && nums[right] == rightValue)
                        {
                            right--;
                        }
                    }else if(nums[left] + nums[right] < target)
                    {
                        left++;
                    }else
                    {
                        right--;
                    }
                }
            }else
            {
                // n > 2递归计算，（n-1)sum的值
                for(var i = start; i < len; i++)
                {
                    var sub = nSumTarget(nums, n - 1, i + 1, target - nums[i]);
                    for(var j = 0; j < sub.Count; j++)
                    {
                        // n-1数之和，加上nums[i]就是n数之和
                        sub[j].Add(nums[i]);
                        res.Add(sub[j]);
                    }
                    // 统计结果去重
                    while(i < len - 1 && nums[i] == nums[i + 1])
                    {
                        i++;
                    }
                }
            }
            return res;
        }
    }
}