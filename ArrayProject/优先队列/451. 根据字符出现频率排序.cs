using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayProject.优先队列
{
    /*https://leetcode.cn/problems/sort-characters-by-frequency/description/*/
    public class 根据字符出现频率排序 {
        public string FrequencySort(string s) {
            var priority = new PriorityQueue<char, int>();
            var dic = new Dictionary<char, int>();
            for(var i = 0; i < s.Length; i++)
            {
                if(dic.ContainsKey(s[i]))
                {
                    dic[s[i]]++;
                }else
                {
                    dic.Add(s[i], 1);
                }
            }
            // 或者直接排序dic
            // var keyValuePair = dic.OrderByDescending(x => x.Value);
            // var sb = new StringBuilder();
            // foreach(var per in keyValuePair)
            // {
            //     sb.Append(new string(per.Key, per.Value));
            // }


            foreach(var per in dic)
            {
                priority.Enqueue(per.Key, per.Value);
            }
            var sb = new StringBuilder();
            while(priority.Count != 0)
            {
                var cur = priority.Dequeue();
                sb.Insert(0, new string(cur,dic[cur]));
            }

            return sb.ToString();
        }
    }
}