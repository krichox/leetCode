using System;

namespace ArrayProject.前缀和
{
    /*https://leetcode.cn/problems/count-days-spent-together/description/*/
    public class 统计共同度过的日子数 {
        public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob) {
            var datesOfMonths = new int[]{31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            // 每个月的前缀和
            int[] prefixSum = new int[13];
            for(var i = 0; i < datesOfMonths.Length; i++)
            {
                prefixSum[i + 1] += prefixSum[i] +  datesOfMonths[i];
            }

            var arriveAliceDay = CalculateDayOfYears(arriveAlice, prefixSum);
            var leaveAliceDay = CalculateDayOfYears(leaveAlice, prefixSum);
            var arriveBobDay = CalculateDayOfYears(arriveBob, prefixSum);
            var leaveBobDay = CalculateDayOfYears(leaveBob, prefixSum);
            return Math.Max(0, Math.Min(leaveAliceDay, leaveBobDay) - Math.Max(arriveAliceDay, arriveBobDay) + 1);

        }

        private int CalculateDayOfYears(string day, int[] prefixSum)
        {
            int month = int.Parse(day.Substring(0, 2));
            int date = int.Parse(day.Substring(3));
            return prefixSum[month - 1] + date;
        }
    }
}