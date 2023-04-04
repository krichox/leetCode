namespace Array.模拟
{
    /*https://leetcode.cn/problems/previous-permutation-with-one-swap/description/*/
    public class Previous_Permutation_With_One_Swap交换一次的先前排列 {
        public int[] PrevPermOpt1(int[] arr) {
            // 逆序遍历寻找i
            var left = -1;
            for(var i = arr.Length - 2; i >= 0; i--)
            {
                if(arr[i] > arr[i + 1])
                {
                    left = i;
                    break;
                }
            }

            if(left == -1)
            {
                return arr;
            }

            // 从i到末尾找到最大且小于arr[i]的值进行交换
            var right = -1;

            var max = int.MinValue;

            for(var i = left + 1; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    right = i;
                    max = arr[i];
                }
            }

            if(right == -1)
            {
                return arr;
            }

            (arr[left], arr[right]) = (arr[right], arr[left]);

            return arr;

        }
    }
}