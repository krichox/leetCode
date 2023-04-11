namespace Greedy
{
    public class 分割平衡字符串 {
        public int BalancedStringSplit(string s) {
            int res = 0, total = 0;

            for(var i = 0; i < s.Length; i++)
            {
                if(s[i] == 'R')
                {
                    total++;
                }else
                {
                    total--;
                }
                if(total == 0)
                {
                    res++;
                }
            }

            return res;
        }
    }
}