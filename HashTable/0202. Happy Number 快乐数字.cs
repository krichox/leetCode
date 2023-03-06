namespace HashTable {}

/*https://leetcode.cn/problems/happy-number/*/

/*Write an algorithm to determine if a number n is happy.

A happy number is a number defined by the following process:

Starting with any positive integer, replace the number by the sum of the squares of its digits.
Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
Those numbers for which this process ends in 1 are happy.
Return true if n is a happy number, and false if not.。*/
public class HappyNumber快乐数字
{
    public bool IsHappy(int n)
    {
        var sum = n;
        var set = new HashSet<int>();
        while (true)
        {
            sum = GetNext(sum);
            if (sum == 1)
            {
                return true;
            }

            if (set.Contains(sum))
            {
                return false;
            }
            

            set.Add(sum);
        }

        return false;
    }

    private int GetNext(int n)
    {
        var res = 0;
        while (n > 0)
        {
            var a = n % 10;
            res += a * a;
            n = n / 10;
        }

        return res;
    }
    
    public bool IsHappy双指针(int n) {
        var slow = n;
        var fast = n;
        do
        {
            slow = GetSeparate(slow);
            fast = GetSeparate(GetSeparate(fast));
        }while(slow != fast);

        return slow == 1;
    }

    private int GetSeparate(int n)
    {
        var sum = 0;
        while(n > 0)
        {
            var temp = n % 10;
            sum += temp * temp;
            n = n / 10;
        }

        return sum;
    }
}