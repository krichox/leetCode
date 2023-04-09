using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueStack
{
    public class 去除相邻重复的字符串
    {
        public string RemoveDuplicates(string s)
        {
            var stack = new Stack<char>();
            foreach (var perStack in s)
            {
                if (stack.Count == 0 || stack.Peek() != perStack)
                {
                    stack.Push(perStack);
                }
                else
                {
                    stack.Pop();
                }
            }
        
            return new string(stack.Reverse().ToArray());
        }

    }
}