using System.Collections.Generic;

namespace ArrayProject.双指针
{
    public class 驼峰式匹配 {
        public IList<bool> CamelMatch(string[] queries, string pattern) {
            var patternLen = pattern.Length;
            var ans = new bool[queries.Length];

            for(var i = 0; i < queries.Length; i++)
            {
                var index = 0;
                var flag = false;
                var curQuery = queries[i];
                var uppderCount = 0;
                for(var j = 0; j < curQuery.Length; j++)
                {
                    if(index < patternLen && curQuery[j] == pattern[index])
                    {
                        index++;
                    }else if(char.IsUpper(curQuery[j]))
                    {
                        flag = true;
                        break;
                    }
                }

                if(index == patternLen && !flag)
                {
                    ans[i] = true;
                }
            }

            return ans;
        }
    }
}