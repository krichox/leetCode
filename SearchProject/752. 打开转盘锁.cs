using System.Collections.Generic;
using System.Linq;

namespace SearchProject
{
    /*https://leetcode.cn/problems/open-the-lock/*/
    public class 打开转盘锁 {
        public int OpenLock(string[] deadends, string target) {
            // BFS最优路径
            if("0000" == target)
            {
                return 0;
            }
            var deadSet = deadends.ToHashSet();
            if(deadSet.Contains("0000"))
            {
                return -1;
            }

            var queue = new Queue<string>();
            var visited = new HashSet<string>();
            queue.Enqueue("0000");
            var step = 0;
            visited.Add("0000");
        
            while(queue.Count != 0)
            {
                var count = queue.Count;
                for(var i = 0; i < count; i++)
                {
                    var cur = queue.Dequeue();
                    // 每一位波动1下的结果加入queue
                    for(var j = 0; j < 4; j++)
                    {
                        var plusAns = PlusOne(cur, j);
                        if(!visited.Contains(plusAns) && !deadSet.Contains(plusAns))
                        {
                            queue.Enqueue(plusAns);
                            visited.Add(plusAns);
                        }

                        var downAns = DownOne(cur, j);
                        if(!visited.Contains(downAns) && !deadSet.Contains(downAns))
                        {
                            queue.Enqueue(downAns);
                            visited.Add(downAns);
                        }

                        if(plusAns == target || downAns == target)
                        {
                            return ++step;
                        }
                    }
                }
                step++;
            }



            return -1;
        }

        string PlusOne(string s, int i)
        {
            var arr = s.ToCharArray();
            if(arr[i] == '9')
            {
                arr[i] = '0';
            }else
            {
                arr[i] += (char) 1;
            }

            return new string(arr);
        }

        string DownOne(string s, int i)
        {
            var arr = s.ToCharArray();
            if(arr[i] == '0')
            {
                arr[i] = '9';
            }else
            {
                arr[i] -= (char) 1;
            }

            return new string(arr);
        }
    }
}