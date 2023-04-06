using System;
using System.Collections.Generic;
using System.Linq;

namespace MonotonicStack
{
    /*https://leetcode.cn/problems/next-greater-element-i/*/
    public class Next_Greater_Element_I下一个更大的元素 {        
        public int[] NextGreaterElement(int[] nums1, int[] nums2) {
            var stack = new Stack<int>();

            var arr = new int[nums2.Length];

            stack.Push(0);

            for(var i = 1; i < nums2.Length; i++)
            {
                while(stack.Count != 0 && nums2[stack.Peek()] < nums2[i])
                {
                    var temp = stack.Pop();
                    arr[temp] = nums2[i];
                }

                stack.Push(i);
            }

            for(var i = 0; i < nums1.Length; i++)
            {
                var index = nums2.ToList().IndexOf(nums1[i]);
                if(arr[index] != 0)
                {
                    nums1[i] = arr[index];
                }
                else{
                    nums1[i] = -1;
                }
            }

            return nums1;

        }
    }
}