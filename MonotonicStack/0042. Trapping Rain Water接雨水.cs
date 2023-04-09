using System;
using System.Collections.Generic;

namespace MonotonicStack
{
    /*https://leetcode.cn/problems/trapping-rain-water/description/*/
    public class Trapping_Rain_Water接雨水 {
    
        public int Trap(int[] height) {
            // 单调栈
            var stack = new Stack<int>();

            stack.Push(0);
            var result = 0;
            for(var i = 1; i < height.Length; i++)
            {
                if(height[i] <= height[stack.Peek()])
                {
                    stack.Push(i);
                }
                else
                {
                    while(stack.Count != 0 && height[i] > height[stack.Peek()])
                    {
                        var mid = stack.Peek();
                        stack.Pop();
                        if(stack.Count != 0)
                        {
                            var left = stack.Peek();
                            var high = Math.Min(height[left], height[i]) - height[mid];
                            var width = i - left - 1;
                            result += high * width;
                        }
                    }
                    stack.Push(i);
                }
            }
            return result;
        }
    }
}