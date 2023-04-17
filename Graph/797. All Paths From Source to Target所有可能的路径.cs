using System.Collections.Generic;

namespace Graph
{
    /*https://leetcode.cn/problems/all-paths-from-source-to-target/description/*/
    // 图的遍历
    public class All_Paths_From_Source_to_Target所有可能的路径
    {
        IList<int> path = new List<int>();
        IList<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            // node从0-> n-1说明，输入是一个邻接表
            // 题目也就是要遍历图
            path.Add(0);
            traverse(graph, 0);
            return result;
        }

        void traverse(int[][] graph, int index)
        {
            if (index == graph.Length - 1)
            {
                result.Add(new List<int>(path));
                return;
            }

            for (var i = 0; i < graph[index].Length; i++)
            {
                path.Add(graph[index][i]);
                traverse(graph, graph[index][i]);
                path.RemoveAt(path.Count - 1);
            }
        }
        
        public IList<IList<int>> AllPathsSourceTarget2(int[] [] graph) {
            // node从0-> n-1说明，输入是一个邻接表
            // 题目也就是要遍历图
            // path.Add(0);
            traverse2(graph, 0);
            return result;
        }


        void traverse2(int[] [] graph, int index)
        {
            path.Add(index);
            if(index == graph.Length - 1)
            {
                result.Add(new List<int>(path));
                path.RemoveAt(path.Count - 1);
                return;
            }

            for(var i = 0; i < graph[index].Length; i++)
            {
                // path.Add(graph[index][i]);
                traverse(graph, graph[index][i]);
                // path.RemoveAt(path.Count - 1);
            }

            path.RemoveAt(path.Count - 1);
        }
        // O(n^2^n)
        // O(n)
    }



}