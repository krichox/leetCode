namespace QueueStack
{
    /*https://leetcode.cn/problems/minimum-insertions-to-balance-a-parentheses-string/*/
    public class 平衡括号字符串的最少插入次数 {
    public int MinInsertions(string s) {
        var res = 0;
        var rightNeed = 0;

        for(var i = 0; i < s.Length; i++)
        {
            if(s[i] == '(')
            {
                rightNeed+=2;
                if(rightNeed % 2 == 1)
                {
                    res++;
                    rightNeed--;
                }
            }else
            {
                rightNeed--;
                if(rightNeed < 0)
                {
                    res++;
                    rightNeed = 1;
                }
            }
        }
        return res + rightNeed;
    }
    }
}