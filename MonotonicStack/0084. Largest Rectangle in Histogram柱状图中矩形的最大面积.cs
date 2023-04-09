using System;
using System.Collections.Generic;

namespace MonotonicStack
{
    /*https://leetcode.cn/problems/largest-rectangle-in-histogram/*/
    public class Largest_Rectangle_in_Histogram柱状图中矩形的最大面积 {
        public int LargestRectangleArea(int[] heights) {
            var stack = new Stack<int>();
            var newHeights = new int[heights.Length + 2];
            newHeights[0] = 0;
            newHeights[newHeights.Length - 1] = 0;
        
            for(var i = 0; i < heights.Length; i++)
            {
                newHeights[i + 1] = heights[i];
            }

            var result = 0;
            stack.Push(0);
            for(var i = 1; i < newHeights.Length; i++)
            {
                if(newHeights[i] >= newHeights[stack.Peek()])
                {
                    stack.Push(i);
                }
                else
                {
                    while(stack.Count != 0 && newHeights[i] < newHeights[stack.Peek()])
                    {
                        var mid = stack.Peek();
                        stack.Pop();
                        if(stack.Count != 0)
                        {
                            var left = stack.Peek();
                            var right = i;
                            var high = newHeights[mid];
                            var width = right - left - 1;
                            result = Math.Max(result, high * width);
                        }
                    }
                    stack.Push(i);
                }
            }
            return result;
        }
    }
}