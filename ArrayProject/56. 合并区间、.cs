using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayProject
{
    /*  https://leetcode.cn/problems/merge-intervals/description/*/
    public class 合并区间_ {
        public int[][] Merge(int[][] intervals) {
            Array.Sort(intervals, (x, y) =>
            {
                return x[0] - y[0];
            });
            var res = new LinkedList<int[]>();
            res.AddLast(new int[]{intervals[0][0], intervals[0][1]});
            for(var i = 1; i < intervals.Length; i++)
            {   
                if(intervals[i][0] <= res.Last.Value[1])
                {
                    res.Last.Value[1] = Math.Max(res.Last.Value[1], intervals[i][1]);
                }else
                {
                    res.AddLast(new int[]{intervals[i][0], intervals[i][1]});
                }
            }

            return res.ToArray();
        }
    }
}