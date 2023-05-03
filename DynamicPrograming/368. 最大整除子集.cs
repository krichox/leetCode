using System.Collections.Generic;

namespace DynamicPrograming
{
    public class 最大整除子集 {
        IList<int> path = new List<int>();
        IList<int> result = new List<int>();
        int max;
        public IList<int> LargestDivisibleSubset(int[] nums) {
            BackTracing(nums, 0);
            return result;

        }

        void BackTracing(int[] nums, int startIndex)
        {
            if(path.Count >= 2)
            {
                if(path.Count > max)
                {
                    result = new List<int>(path);
                    max = path.Count;
                }

            }
            if(startIndex >= nums.Length)
            {
                return;
            }

            for(var i = startIndex; i < nums.Length; i++)
            {
                if(IsValid(nums[i], path))
                {
                    path.Add(nums[i]);
                    BackTracing(nums, i + 1);
                    path.RemoveAt(path.Count - 1);
                }

            }
        }

        bool IsValid(int i, IList<int> path)
        {
            if(path.Count == 0)
            {
                return true;
            }
            for(var j = 0; j < path.Count; j++)
            {
                if(path[j] % i != 0 && i % path[j] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}