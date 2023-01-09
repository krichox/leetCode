namespace HashTable;

/*https://leetcode.cn/problems/4sum-ii/*/
/*Given four integer arrays nums1, nums2, nums3, and nums4 all of length n, return the number of tuples (i, j, k, l) such that:

0 <= i, j, k, l < n
nums1[i] + nums2[j] + nums3[k] + nums4[l] == 0

Example 1:

Input: nums1 = [1,2], nums2 = [-2,-1], nums3 = [-1,2], nums4 = [0,2]
Output: 2
Explanation:
The two tuples are:
1. (0, 0, 0, 1) -> nums1[0] + nums2[0] + nums3[0] + nums4[1] = 1 + (-2) + (-1) + 2 = 0
2. (1, 1, 0, 0) -> nums1[1] + nums2[1] + nums3[0] + nums4[0] = 2 + (-1) + (-1) + 0 = 0
Example 2:

Input: nums1 = [0], nums2 = [0], nums3 = [0], nums4 = [0]
Output: 1
。*/
public class 两数之和2
{
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
    {
        var dic = new Dictionary<int, int>();
        foreach (var i in nums1)
        {
            foreach (var j in nums2)
            {
                var sum = i + j;
                if (dic.ContainsKey(i + j))
                {
                    dic[i + j] += 1;
                }
                else
                {
                    dic[i + j] = 1;
                }
            }
        }

        var res = 0;
        foreach (var i in nums3)
        {
            foreach (var j in nums4)
            {
                var temp = i + j;
                if (dic.ContainsKey(-i - j))
                {
                    res += dic[-i - j];
                }
            }
        }

        return res;
    }
}