using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Graph
{
    /*https://leetcode.cn/problems/flower-planting-with-no-adjacent/description/*/
    public class Flower_Planting_With_No_Adjacent不相邻种花 {
        public int[] GardenNoAdj(int n, int[][] paths)
        {
            List<IList<int>> graph = new();
            for (var i = 0; i < n; i++)
            {
                // 邻接表
                graph.Add(new List<int>());
            }
            // 构建邻接表
            for (var i = 0; i < paths.Length; i++)
            {
                graph[paths[i][0] - 1].Add(paths[i][1] - 1);
                graph[paths[i][1] - 1].Add(paths[i][0] - 1);
            }


            var res = new int[n];
            // 遍历花园
            for (var i = 0; i < n; i++)
            {
                var colors = new HashSet<int> {1, 2, 3, 4};
                // 遍历该花园相邻的花园
                for (var j = 0; j < graph[i].Count; j++)
                {
                    colors.Remove(res[graph[i][j]]);
                }

                res[i] = colors.First();
            }

            return res;




        }
    }
}