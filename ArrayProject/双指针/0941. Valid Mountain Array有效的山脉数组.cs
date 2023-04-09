namespace Array.双指针
{
    /*https://leetcode.cn/problems/valid-mountain-array/description/*/
    public class Valid_Mountain_Array有效的山脉数组 {
        public bool ValidMountainArray(int[] arr) {
            if(arr.Length < 3)
            {
                return false;
            }

            var left = 0;
            var right = arr.Length - 1;

            while(left + 1 < arr.Length && arr[left] < arr[left + 1])
            {
                left++;
            }

            while(right - 1 >= 0 && arr[right] < arr[right - 1])
            {
                right--;
            }

            if(left == right && left != 0 && right != arr.Length -1)
            {
                return true;
            }

            return false;
        }
    }
}