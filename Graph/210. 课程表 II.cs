using System.Collections.Generic;

namespace Graph
{
    /*https://leetcode.cn/problems/course-schedule-ii/description/*/
    public class 课程表_II {
        public int[] FindOrder(int numCourses, int[][] prerequisites) {
            // 判断是否有环，并且返回结果
            var graph = new HashSet<int>[numCourses];

            for(var i = 0; i < numCourses; i++)
            {
                graph[i] = new HashSet<int>();
            }

            var ingrss = new int[numCourses];

            // build graph
            for(var i = 0; i < prerequisites.Length; i++)
            {
                graph[prerequisites[i][1]].Add(prerequisites[i][0]);
                ingrss[prerequisites[i][0]]++;
            }
            var queue = new Queue<int>();
            for(var i = 0; i < ingrss.Length; i++)
            {
                if(ingrss[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            var count = 0;
            var result = new List<int>();

            while(queue.Count != 0)
            {
                var cur = queue.Dequeue();
                result.Add(cur);
                count++;
                // 遍历邻接节点
                foreach(var perNode in graph[cur])
                {
                    ingrss[perNode]--;
                    if(ingrss[perNode] == 0)
                    {
                        queue.Enqueue(perNode);
                    }
                }
            }

            if(count == numCourses)
            {
                return result.ToArray(); 
            }else
            {
                return new int[0];
            }
        }
    }
}