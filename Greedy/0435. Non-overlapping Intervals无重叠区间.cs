using System;

namespace Greedy
{
    /*https://leetcode.cn/problems/non-overlapping-intervals/description/*/
    public class Non_overlapping_Intervals无重叠区间 {
        public int EraseOverlapIntervals(int[][] intervals) {
            if(intervals.Length == 0)
            {
                return 0;
            }
            
            var result = 0;
            Array.Sort(intervals, (x, y) => 
            {
                if(x[0] == y[0])
                {
                    return x[1].CompareTo(y[1]);
                }

                return x[0].CompareTo(y[0]);
            });

            for(var i = 1; i < intervals.Length; i++)
            {
                if(intervals[i][0] < intervals[i - 1][1])
                {
                    result++;
                    intervals[i][1] = Math.Min(intervals[i - 1][1], intervals[i][1]);
                }
            }

            return result;
        }
    }
}