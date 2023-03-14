using System;
using System.Collections.Generic;
using System.Linq;

namespace Array
{
    /*https://leetcode.cn/problems/reconstruct-itinerary/
     You are given a list of airline tickets where tickets[i] = [fromi, toi] represent the departure and the arrival airports of one flight. Reconstruct the itinerary in order and return it.

All of the tickets belong to a man who departs from "JFK", thus, the itinerary must begin with "JFK". If there are multiple valid itineraries, you should return the itinerary that has the smallest lexical order when read as a single string.

For example, the itinerary ["JFK", "LGA"] has a smaller lexical order than ["JFK", "LGB"].
You may assume all tickets form at least one valid itinerary. You must use all the tickets once and only once.

 

Example 1:


Input: tickets = [["MUC","LHR"],["JFK","MUC"],["SFO","SJC"],["LHR","SFO"]]
Output: ["JFK","MUC","LHR","SFO","SJC"]
Example 2:


Input: tickets = [["JFK","SFO"],["JFK","ATL"],["SFO","ATL"],["ATL","JFK"],["ATL","SFO"]]
Output: ["JFK","ATL","JFK","SFO","ATL","SFO"]
Explanation: Another possible reconstruction is ["JFK","SFO","ATL","JFK","ATL","SFO"] but it is larger in lexical order.*/

    public class Reconstruct_Itinerary重新安排行程
    {
        public IList<string> result = new List<string>();
        public IList<string> path = new List<string>();

        private IDictionary<string, Dictionary<string, int>>
            targets = new Dictionary<string, Dictionary<string, int>>();

        Dictionary<string, bool> used = new Dictionary<string, bool>();

        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            var ticket = tickets.ToList().OrderBy(x => x[1]).ToList();

            bool[] used = new bool[tickets.Count];
            path.Add("JFK");
            BackTracing(ticket, used);
            return result;
        }

        bool BackTracing(IList<IList<string>> tickets, bool[] used)
        {
            // end condition
            // ticket数量加一就收集
            if (path.Count == tickets.Count + 1)
            {
                foreach (var per in path)
                {
                    result.Add(per);
                }

                return true;
            }


            // 全排列所有， 选择还没有使用过的路程
            for (var i = 0; i < tickets.Count; i++)
            {
                if (!used[i] && tickets[i][0].Equals(path[^1]))
                {
                    path.Add(tickets[i][1]);
                    used[i] = true;

                    if (BackTracing(tickets, used))
                    {
                        return true;
                    }

                    used[i] = false;
                    path.RemoveAt(path.Count - 1);
                }
            }

            return false;
        }
    }
}

