using System;

namespace ArrayProject
{
    /*https://leetcode.cn/problems/sort-the-people/description/*/
    public class 按身高排序 {
        public string[] SortPeople(string[] names, int[] heights) {
            var arr = new int[heights.Length];

            // 先将身高映射index
            for(var i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            // 根据身高降序
            Array.Sort(arr, (x, y) => heights[y] - heights[x]);
            var res = new string[names.Length];

            for(var i = 0; i < res.Length; i++)
            {
                // 答案赋值
                res[i] = names[arr[i]];
            }

            return res;
        }
    }
}