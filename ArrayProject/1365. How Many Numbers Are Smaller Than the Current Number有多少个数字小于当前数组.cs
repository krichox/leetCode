using System.Collections.Generic;

namespace ArrayProject
{
    public class How_Many_Numbers_Are_Smaller_Than_the_Current_Number有多少个数字小于当前数组 {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        // 排序根据下标判断前面有多少个数小于
        var n = nums.Length;
        var res = new int[n];
        System.Array.Copy(nums, res, n);
        var dic = new Dictionary<int, int>();

        System.Array.Sort(res);

        for(var i = 0; i < n; i++)
        {
            if(!dic.ContainsKey(res[i]))
            {
                dic.Add(res[i], i);
            }
        }

        for(var i = 0; i < n; i++)
        {
            res[i] = dic[nums[i]];
        }

        return res;
        

        // // 暴力解法
        // var res = new int[nums.Length];
        // for(var i = 0; i < nums.Length; i++)
        // {
        //     var index = i + 1;
        //     var count = 0;
        //     for(var j = 0; j < nums.Length; j++)
        //     {
        //         if(nums[j] < nums[i])
        //         {
        //             count++;
        //         }
        //     }
        //     res[i] = count;
        // }

        // return res;
    }
    }
}