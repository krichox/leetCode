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
    }
}