namespace QueueStack
{
    /*https://leetcode.cn/problems/minimum-add-to-make-parentheses-valid/description/*/
    public class 使括号有效的最少添加 {
        public int MinAddToMakeValid(string s) {
            var rightNeed = 0;
            var res = 0;

            for(var i = 0; i < s.Length; i++)
            {
                if(s[i] == '(')
                {
                    rightNeed++;
                }else
                {
                    rightNeed--;
                    if(rightNeed < 0)
                    {
                        res++;
                        rightNeed = 0;
                    }
                }
            }
            return rightNeed + res;
        }
    }
}