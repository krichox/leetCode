using System.Collections.Generic;

namespace Graph
{
    /*https://leetcode.cn/problems/course-schedule/description/*/
    public class 课程表 {
   bool[] visited;
    bool[] onPath;
    bool hasCircle = false;
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var len = prerequisites.Length;
        var graph = new List<int>[numCourses];
        visited = new bool[numCourses];
        onPath = new bool[numCourses];
        
        // 初始化
        for(var i = 0; i < numCourses; i++)
        {
            graph[i] = new List<int>();
        }

        // build邻接图
        for(var i = 0; i < len; i++)
        {
            var from = prerequisites[i][1];
            var to = prerequisites[i][0];
            graph[from].Add(to);
        }

        // 遍历图中所有节点
        for(var i = 0; i < numCourses; i++)
        {
            traverse(graph, i);        
        }
        
        return !hasCircle;
    }

        void traverse(List<int>[] graph, int s)
        {
            // 递归栈中重复访问
            if(onPath[s])
            {
                hasCircle = true;
            }

            if(visited[s] || hasCircle)
            {
                return;
            }

            // 前序位置
            visited[s] = true;
            onPath[s] = true;

            foreach(var edge in graph[s])
            {
                traverse(graph, edge);
            }
       
            onPath[s] = false;
        }
        
        // BFS拓扑排序 
        public bool CanFinish2(int numCourses, int[][] prerequisites) {
            var graph = new HashSet<int>[numCourses];
        
            for(var i = 0; i < graph.Length; i++)
            {
                graph[i] = new HashSet<int>();
            }
            var ingree = new int[numCourses];
            for(var i = 0; i < prerequisites.Length; i++)
            {
                graph[prerequisites[i][1]].Add(prerequisites[i][0]);
                ingree[prerequisites[i][0]]++;
            }

            var queue = new Queue<int>();

            // 入度为0的加入队列
            for(var i = 0; i < ingree.Length; i++)
            {
                if(ingree[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            var count = 0;
            while(queue.Count != 0)
            {
                var cur = queue.Dequeue();
                count++;
                foreach(var per in graph[cur])
                {
                    ingree[per]--;
                    if(ingree[per] == 0)
                    {
                        queue.Enqueue(per);
                    }
                }
            }

            return count == numCourses;
        }
    }
    
}