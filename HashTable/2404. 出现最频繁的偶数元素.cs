using System.Collections.Generic;

namespace HashTable
{
    /*https://leetcode.cn/problems/most-frequent-even-element/description/
     */
    public class 出现最频繁的偶数元素
    {
        public int MostFrequentEven(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            var max = int.MinValue;
            var num = int.MinValue;
            for (var i = 0; i < nums.Length; i++)
            {
                var cur = nums[i];
                if ((cur & 1) == 0)
                {
                    if (!dic.ContainsKey(cur))
                    {
                        dic.Add(cur, 1);
                    }
                    else
                    {
                        dic[cur]++;

                    }

                    if (dic[cur] > max)
                    {
                        max = dic[cur];
                        num = cur;
                    }
                }
            }

            var sameFreSmallNum = int.MaxValue;

            foreach (var perDic in dic)
            {
                if (perDic.Value == max && perDic.Key < sameFreSmallNum)
                {
                    sameFreSmallNum = perDic.Key;
                }
            }

            return max == int.MinValue ? -1 : sameFreSmallNum;
        }
    }
}