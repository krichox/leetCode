namespace 算法排序
{
    /*https://leetcode.cn/problems/shu-zu-zhong-de-ni-xu-dui-lcof/description/*/
    public class 剑指_Offer_51__数组中的逆序对
    {
        // 归并排序的应用，在merge的时候可以算出逆序对
        public int ReversePairs(int[] nums)
        {
            // var copy = new int[nums.Length];
            // for(var i = 0; i < nums.Length; i++)
            // {
            //     copy[i] = nums[i];
            // }
            if (nums.Length < 2)
            {
                return 0;
            }

            var temp = new int[nums.Length];
            return CountReversePairs(nums, 0, nums.Length - 1, temp);
        }

        private int CountReversePairs(int[] nums, int left, int right, int[] temp)
        {
            if (left == right)
            {
                return 0;
            }

            var mid = left + (right - left) / 2;
            // [left, mid]
            var leftReversePairs = CountReversePairs(nums, left, mid, temp);
            // [mid + 1, right]
            var rightReversePairs = CountReversePairs(nums, mid + 1, right, temp);
            if(nums[mid] <= nums[mid + 1])
            {
                return leftReversePairs + rightReversePairs;
            }
            var crossPairs = CrossPairs(nums, left, mid, right, temp);

            return leftReversePairs + rightReversePairs + crossPairs;
        }

        private int CrossPairs(int[] nums, int left, int mid, int right, int[] temp)
        {
            // 将数组的值复制到temp上，在划分的两个区间在temp比较，合并到nums数组上
            for (var i = left; i <= right; i++)
            {
                temp[i] = nums[i];
            }


            // 分别指向两个数组的开头,双指针操作
            var leftIndex = left;
            var rightIndex = mid + 1;
            var crossPairs = 0;
            for (var i = left; i <= right; i++)
            {
                if (leftIndex == mid + 1)
                {
                    nums[i] = temp[rightIndex];
                    rightIndex++;
                }
                else if (rightIndex == right + 1)
                {
                    nums[i] = temp[leftIndex];
                    leftIndex++;
                }
                // 此处注意是temp数组之间进行比较
                else if (temp[leftIndex] <= temp[rightIndex])
                {
                    nums[i] = temp[leftIndex];
                    leftIndex++;
                }
                else
                {
                    nums[i] = temp[rightIndex];
                    rightIndex++;
                    crossPairs += mid - leftIndex + 1;
                }
            }

            return crossPairs;
        }
        // O(NlogN)
        // O(N)开辟了数组长度为n
    }
}