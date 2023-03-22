using System;
using System.Linq;

namespace Greedy
{
    /*https://leetcode.cn/problems/candy/description/
     There are n children standing in a line. Each child is assigned a rating value given in the integer array ratings.

You are giving candies to these children subjected to the following requirements:

Each child must have at least one candy.
Children with a higher rating get more candies than their neighbors.
Return the minimum number of candies you need to have to distribute the candies to the children.

 

Example 1:

Input: ratings = [1,0,2]
Output: 5
Explanation: You can allocate to the first, second and third child with 2, 1, 2 candies respectively.
Example 2:

Input: ratings = [1,2,2]
Output: 4
Explanation: You can allocate to the first, second and third child with 1, 2, 1 candies respectively.
The third child gets 1 candy because it satisfies the above two conditions.*/
    public class Candy分发糖果 {
        public int Candy(int[] ratings) {
            var candy = new int[ratings.Length];
            Array.Fill(candy, 1);
            // 正向遍历，右边比左边大
            for(var i = 1; i < ratings.Length; i++)
            {
                if(ratings[i] > ratings[i - 1])
                {
                    candy[i] = candy[i - 1] + 1;
                }
            }
            // 逆序遍历，左边比右边大
            for(var i = ratings.Length - 2; i >= 0; i--)
            {
                if(ratings[i] > ratings[i + 1])
                {
                    candy[i] = Math.Max(candy[i + 1] + 1, candy[i]);
                }
            }
            return candy.Sum();
        }
    }
}