using System;
using System.Collections.Generic;
using System.Linq;

namespace HashTable
{
    /*https://leetcode.cn/problems/4sum/*/

/*Given an array nums of n integers, return an array of all the unique quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:

0 <= a, b, c, d< n
a, b, c, and d are distinct.
nums[a] + nums[b] + nums[c] + nums[d] == target
You may return the answer in any order.

Example 1:

Input: nums = [1,0,-1,0,-2,2], target = 0
Output: [[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]

Example 2:
Input: nums = [2,2,2,2,2], target = 8
Output: [[2,2,2,2]]*/
    public class Sum4数之和
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();
            // 排序
            Array.Sort(nums);
            for (var i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (j > i + 1 && nums[j - 1] == nums[j])
                    {
                        continue;
                    }

                    var left = j + 1;
                    var right = nums.Length - 1;
                    while (right > left)
                    {
                        var sum = nums[i] * 1l + nums[j] + nums[left] + nums[right];
                        if (sum > target)
                        {
                            right--;
                        }
                        else if (sum < target)
                        {
                            left++;
                        }
                        else
                        {
                            var res = new int[4] { nums[i], nums[j], nums[left], nums[right] }.ToList();
                            result.Add(res);
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
            }

            return result;
        }
    }
}