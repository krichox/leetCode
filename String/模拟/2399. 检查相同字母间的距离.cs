namespace Array
{
    /*https://leetcode.cn/problems/check-distances-between-same-letters/*/
    public class 检查相同字母间的距离 {
        public bool CheckDistances(string s, int[] distance) {
            var firstIndex = new int[26];
            for(var i = 0; i < s.Length; i++)
            {
                var cur = s[i] - 97;
                if(firstIndex[cur] != 0)
                {
        
                    if(i - firstIndex[cur] != distance[cur])
                    {
                        return false;
                    }
                }else
                {
                    firstIndex[cur] = i + 1;
                }

            }

            return true;
        }
        }
    }
}