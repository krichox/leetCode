using System.Collections.Generic;
using System.Text;

namespace Backtracking.组合
{
    public class Generate_Parentheses生成括号 {
        IList<string> result = new List<string>();
        public IList<string> GenerateParenthesis(int n) {
        
            backTracing(n, n, "");
            return result;
        }

        void backTracing(int left, int right, string path)
        {
            while (true)
            {
                // 左括号多余右括号
                if (left > right)
                {
                    return;
                }

                if (left < 0 || right < 0)
                {
                    return;
                }

                if (left == 0 && right == 0)
                {
                    result.Add(path);
                    return;
                }

                // 尝试左括号
                backTracing(left - 1, right, path + "(");

                // 尝试右括号
                right -= 1;
                path += ")";
            }
        }
    }
}