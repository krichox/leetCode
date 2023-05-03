using System;

namespace OtherProject
{
    /*https://leetcode.cn/problems/number-of-common-factors/description/*/
    public class Number_of_Common_Factors公因子的数目 {
        public int CommonFactors(int a, int b) {
            var min = Math.Min(a, b);
            var result = 0;
            for(var i = 1; i <= min; i++ )
            {
                if(a % i == 0 && b % i == 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}