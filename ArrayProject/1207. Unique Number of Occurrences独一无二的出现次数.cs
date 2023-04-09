namespace ArrayProject
{
    /*https://leetcode.cn/problems/unique-number-of-occurrences/description/*/
    public class Unique_Number_of_Occurrences独一无二的出现次数 {
        public bool UniqueOccurrences(int[] arr) {
            var count = new int[2002];
            for(var i = 0; i < arr.Length; i++)
            {
                count[arr[i] + 1000]++;
            }
            var fre = new bool[2002];
            for(var i = 0; i < count.Length; i++)
            {
                if(count[i] > 0)
                {
                    if(fre[count[i]])
                    {
                        return false;
                    }else
                    {
                        fre[count[i]] = true;
                    }
                }

            }

            return true;
        }
    }
}