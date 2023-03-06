using System.Collections;

namespace QueueStack {}

/*Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.

Example 1:
Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
*/
public class 有效对括号
{
    public bool IsValid(string s)
    {
        var stack = new Stack();
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '{')
            {
                stack.Push('}');
            }
            else if (s[i] == '(')
            {
                stack.Push(')');
            }
            else if (s[i] == '[')
            {
                stack.Push(']');
            }
            else if (stack.Count == 0 || (char)stack.Peek() != s[i])
            {
                return false;
            }
            else
            {
                stack.Pop();
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }

        return false;
    }
}