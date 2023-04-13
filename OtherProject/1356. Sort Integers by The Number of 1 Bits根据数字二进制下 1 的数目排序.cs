using System;

namespace OtherProject
{
    public class 根据数字二进制下1的数目排序 {
        public int[] SortByBits(int[] arr) {

            Array.Sort(arr, (x ,y) =>
            {
                if(bitCount(x) != bitCount(y))
                {
                    return bitCount(x) - bitCount(y);
                }
                return x - y;
            });

            return arr;
        }

        private int bitCount(long x)
        {
            var count = 0;
            while( x > 0)
            {
                if ((x & 1) > 0)
                {
                    count++;
                }

                x >>= 1;
            }
            return count;
        }
    }
}