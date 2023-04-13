namespace AndLookup
{
    /*https://leetcode.cn/problems/redundant-connection/description/*/
    public class 冗余连接
    {
        private int n;
        private int[] father;

        public int[] FindRedundantConnection(int[][] edges)
        {
            n = 1005;
            father = new int[n];

            for (var i = 0; i < n; i++)
            {
                father[i] = i;
            }

            for (var i = 0; i < edges.Length; i++)
            {
                if (same(edges[i][0], edges[i][1]))
                {
                    return edges[i];
                }
                else
                {
                    join(edges[i][0], edges[i][1]);
                }
            }

            return null;
        }

        // 将v->u 这条边加入并查集
        private void join(int u, int v)
        {
            u = find(u);
            v = find(v);
            if (u == v)
            {
                return;
            }

            father[v] = u;
        }


        // 并查集寻根
        private int find(int u)
        {
            return u == father[u] ? u : father[u] = find(father[u]);
        }

        bool same(int u, int v)
        {
            u = find(u);
            v = find(v);
            return u == v;
        }
    }
}