using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Greedy
{
    /*https://leetcode.cn/problems/merge-intervals/*/
    public class Merge_Intervals合并区间
    {
        public int[][] Merge(int[][] intervals) {
            var result = new LinkedList<int[]>();
            Array.Sort(intervals, (x, y) =>
            {
                if (x[0] == y[0])
                {
                    return x[1].CompareTo(y[1]);
                }

                return x[0].CompareTo(y[0]);
            });

            result.AddLast(new[] {intervals[0][0], intervals[0][1]});
            for (var i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] <= intervals[i - 1][1])
                {
                    result.RemoveLast();
                    // 更新左右区间
                    intervals[i][1] = Math.Max(intervals[i][1], intervals[i - 1][1]);
                    intervals[i][0] = Math.Min(intervals[i][0], intervals[i - 1][0]);
                    result.AddLast(new[] {intervals[i - 1][0], intervals[i][1]});

                }else
                {
                    result.AddLast(new[] {intervals[i][0], intervals[i][1]} );
                }
            }

            return result.ToArray();
        }
        
        public int[][] Merge2(int[][] intervals) {
            var result = new LinkedList<int[]>();
            Array.Sort(intervals, (x, y) =>
            {
                if (x[0] == y[0])
                {
                    return x[1].CompareTo(y[1]);
                }

                return x[0].CompareTo(y[0]);
            });

            result.AddLast(new[] {intervals[0][0], intervals[0][1]});
            for (var i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] <= result.Last.Value[1])
                {
                    // 更新左右区间
                    result.Last.Value[1] = Math.Max(intervals[i][1], result.Last.Value[1]);
                }else
                {
                    result.AddLast(new[] {intervals[i][0], intervals[i][1]} );
                }
            }

            return result.ToArray();
        }
    }
    
    
}