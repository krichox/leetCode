using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MonotonicStack
{
    /*https://leetcode.cn/problems/daily-temperatures/*/
    public class Daily_Temperatures每日温度 {
        public int[] DailyTemperatures(int[] temperatures) {
            var stack = new Stack<int>();
            var result = new int[temperatures.Length];
            stack.Push(0);
            for(var i = 1; i < temperatures.Length; i++)
            {

                while(stack.Count != 0 && temperatures[stack.Peek()] < temperatures[i])
                {
                    var temp = stack.Pop();
                    result[temp] = i - temp;
                }
                stack.Push(i);
            
            }

            return result;
        }
    }
}