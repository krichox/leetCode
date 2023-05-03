using System.Collections.Generic;
using System.Text;

namespace QueueStack
{
    /*https://leetcode.cn/problems/check-if-word-is-valid-after-substitutions/description/*/
    public class 检查替换后的词是否有效 {    
        public bool IsValid(string s) {
            // 类似有效括号
            var stack = new Stack<char>();
            var sb = new StringBuilder();
            var n = s.Length;
            if(s.Length == 0)
            {
                return true;
            }

            for(var i = 0; i < n; i++)
            {
                sb.Append(s[i]);
                if(sb.Length >= 3 && sb.ToString().Substring(sb.Length - 3, 3) == "abc")
                {
                    sb.Remove(sb.Length - 3, 3);
                }
                // if(s[i] == 'a')
                // {
                //     stack.Push(s[i]);
                // }else if(s[i] == 'b')
                // {
                //     if(stack.Count == 0 || stack.Peek() != 'a')
                //     {
                //         return false;
                //     }
                //     stack.Push(s[i]);
                // }else if(s[i] == 'c')
                // {
                //     if(stack.Count == 0 || stack.Peek() != 'b')
                //     {
                //         return false;
                //     }
                //     stack.Pop();
                //     stack.Pop();

                // }
            }

            // return stack.Count == 0;
            return sb.Length == 0;
        }
    }
}