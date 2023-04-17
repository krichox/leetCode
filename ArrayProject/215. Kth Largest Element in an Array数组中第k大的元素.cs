using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProject
{
    public class Kth_Largest_Element_in_an_Array数组中第k大的元素 {
        /*快排的时间复杂度我觉得是T(n) = T(n/2) + n，首先不是一个完全的递归树，按照每次排序刚好定位到中间来想，递归树的下一层只有T(n/2)，不考虑另一半；其次，每一层递归树都要遍历对应的, "分而治之"的”分“后的数组长度，所以+n 这样来算用Master method，T(n) = aT(n/b) + f(n), f(n) = n,a=1,b=2, f(n) = Ω(n的 (以b为底a的对数 + x) 次方 )，x>0, 所以T(n) = O(f(n))=O(n)*/
        Random random = new Random();
        public int FindKthLargest(int[] nums, int k) {
            // 优先队列，维持一个最小堆
            var pq = new PriorityQueue<int, int>();

            for(var i = 0; i < nums.Length; i++)
            {
                if(pq.Count < k)
                {
                    pq.Enqueue(nums[i], nums[i]);
                }else
                {
                    if(nums[i] > pq.Peek())
                    {
                        pq.Dequeue();
                        pq.Enqueue(nums[i], nums[i]);
                    }
                }
            }


            return pq.Dequeue();
            // O（n）, 遍历元素O（n）， 堆内调整元素（logk）
            // O(k) -> 声明优先队列，长度为k
        }
        
        // 基于快速排序， 减而治之
        public int FindKthLargest2(int[] nums, int k)
        {
            var len = nums.Length;
            var left = 0;
            var right = len - 1;
            while(true)
            {
                var res = partition(nums, left, right);
                if(res == len - k)
                {
                    return nums[res];
                }else if(res > len - k)
                {
                    right = res - 1;
                }else
                {
                    left = res + 1;
                }
            }
        }
        
        
        int partition(int[] nums, int left, int right)
        {
            // 获取随机数
            var randomIndex = random.Next(left, right);
        
            var pivot = nums[randomIndex];

            // pivotIndex 和left换位置
            (nums[left], nums[randomIndex]) = (nums[randomIndex], nums[left]);

            var le = left + 1;
            var ge = right;
            while(true)
            {
                while(le <= ge && nums[le] < pivot)
                {
                    le++;
                }

                while(le <= ge && nums[ge] > pivot)
                {
                    ge--;
                }

                // le第一次来到大于pivot的位置
                // ge第一次来到小于pivot的位置
                if(le >= ge)
                {
                    break;
                }

                (nums[le], nums[ge]) = (nums[ge], nums[le]);
                le++;
                ge--;
            }

            (nums[left], nums[ge]) = (nums[ge], nums[left]);

            return ge;
        }
    }
}