using System;

namespace Greedy
{
    /*https://leetcode.cn/problems/minimum-number-of-arrows-to-burst-balloons/*/
    public class Minimum_Number_of_Arrows_to_Burst_Balloons用最少数量的箭引爆气球 {
        public int FindMinArrowShots(int[][] points) {
            if(points.Length == 0)
            {
                return 0;
            }
            Array.Sort(points, (x, y) => x[0].CompareTo(y[0]));
            var result = 1;
            for(var i = 1; i < points.Length; i++)
            {
                if(points[i][0] > points[i - 1][1])
                {
                    result++;
                }else
                {
                    points[i][1] = Math.Min(points[i][1], points[i - 1][1]);     
                }
            }

            return result;
        }
    }
}