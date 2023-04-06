using System;
using System.Collections.Generic;

namespace MonotonicStack
{
    /*https://leetcode.cn/problems/next-greater-element-ii/*/
    public class Next_Greater_Element_II下一个最大的元素2 {
        public int[] NextGreaterElements(int[] nums) {
            var stack = new Stack<int>();

            var result = new int[nums.Length];
        
            Array.Fill(result, -1);
            stack.Push(0);

            for(var i = 1; i < nums.Length * 2; i++)
            {
                var index = i % nums.Length;

                while(stack.Count != 0 && nums[index] > nums[stack.Peek()])
                {
                    result[stack.Peek()] = nums[index];
                    stack.Pop();
                }

                stack.Push(index);

            }
        
            return result;
        }
    }
}