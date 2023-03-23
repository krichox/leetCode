using System.Collections.Generic;
using System.Diagnostics;

/*https://leetcode.cn/problems/evaluate-reverse-polish-notation/*/
/*Evaluate the value of an arithmetic expression in Reverse Polish Notation.

Valid operators are +, -, *, and /. Each operand may be an integer or another expression.

Note that division between two integers should truncate toward zero.

It is guaranteed that the given RPN expression is always valid. That means the expression would always evaluate to a result, and there will not be any division by zero operation.


Example 1:

Input: tokens = ["2","1","+","3","*"]
Output: 9
Explanation: ((2 + 1) * 3) = 9
Example 2:

Input: tokens = ["4","13","5","/","+"]
Output: 6
Explanation: (4 + (13 / 5)) = 6
Example 3:

Input: tokens = ["10","6","9","3","+","-11","*","/","*","17","+","5","+"]
Output: 22
Explanation: ((10 * (6 / ((9 + 3) * -11))) + 17) + 5
= ((10 * (6 / (12 * -11))) + 17) + 5
= ((10 * (6 / -132)) + 17) + 5
= ((10 * 0) + 17) + 5
= (0 + 17) + 5
= 17 + 5
= 22*/
namespace QueueStack {}

public class 逆波兰表达式求值
{
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        for(var i = 0; i < tokens.Length; i ++)
        {
            if(tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/")
            {
                var num1 = stack.Pop();
                var num2 = stack.Pop();
                var sum = 0;
                if(tokens[i] == "+")
                {
                    stack.Push(num1 + num2);
                }else if(tokens[i] == "-")
                {
                    stack.Push(num2 - num1);
                }else if(tokens[i] == "*")
                {
                    stack.Push(num1 * num2);
                }else
                {
                    stack.Push(num2 / num1);
                }
                
            }else
            {
                stack.Push(int.Parse(tokens[i]));
            }
        }

        return stack.Pop();
    }
}