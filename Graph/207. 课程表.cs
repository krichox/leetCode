using System.Collections.Generic;

namespace Graph
{
    /*https://leetcode.cn/problems/course-schedule/description/*/
    public class 课程表 {
        public bool CanFinish(int numCourses, int[][] prerequisites) {
            var len = prerequisites.Length;
            var graph = new List<int>[len];
        
            for(var i = 0; i < len; i++)
            {
                graph[i] = new List<int>();
            }
        
        }
    }
}