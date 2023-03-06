namespace HashTable {}

/*https://leetcode.cn/problems/intersection-of-two-arrays/*/
/*Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must be unique and you may return the result in any order.

Example 1:
Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2]

Example 2:
Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [9,4]
Explanation: [4,9] is also accepted.
。*/
public class 求两个相交的数组
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var set = new HashSet<int>();
        var intersectSet = new HashSet<int>();
        for (var i = 0; i < nums1.Length; i++)
        {
            set.Add(nums1[i]);
        }

        for (var i = 0; i < nums2.Length; i++)
        {
            if (set.Contains(nums2[i]))
            {
                intersectSet.Add(nums2[i]);
            }
        }

        var index = 0;
        var result = new int[intersectSet.Count];
        foreach (var i in intersectSet)
        {
            result[index++] = i;
        }

        return result;
    }
}