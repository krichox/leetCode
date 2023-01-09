namespace Array.双指针;

/*给定 s 和 t 两个字符串，当它们分别被输入到空白的文本编辑器后，如果两者相等，返回 true 。# 代表退格字符。

注意：如果对空文本输入退格字符，文本继续为空。

示例 1：

输入：s = "ab#c", t = "ad#c"
输出：true
解释：s 和 t 都会变成 "ac"。
示例 2：

输入：s = "ab##", t = "c#d#"
输出：true
解释：s 和 t 都会变成 ""。
示例 3：

输入：s = "a#c", t = "b"
输出：false
解释：s 会变成 "c"，但 t 仍然是 "b"。
提示：

1 <= s.length, t.length <= 200
s 和 t 只含有小写字母以及字符 '#'
进阶：

你可以用 O(n) 的时间复杂度和 O(1) 的空间复杂度解决该问题吗？
Related Topics
栈
双指针
字符串
模拟*/
public class 比较含退格的字符串 {
    public bool BackspaceCompare(string s, string t) {
        var skipS = 0;
        var skipT = 0;
        var i = s.Length - 1;
        var j = t.Length - 1;
        while(i >= 0 || j >=0)
        {
            while(i >= 0)
            {
                if(s[i] == '#')
                {
                    skipS++;
                    i--;
                }else if(skipS > 0)
                {
                    skipS--;
                    i--;
                }else
                {
                    break;
                }
            }


            while(j >= 0)
            {
                if(s[j] == '#')
                {
                    skipT++;
                    j--;
                }else if(skipT > 0)
                {
                    skipT--;
                    j--;
                }else
                {
                    break;
                }
            }

            // 都还没有走完
            if(i >= 0 && j >= 0)
            {
                if(s[i] != t[j])
                {
                    return false;
                }
                // 其中一个遍历完了
            }else
            {
                // 其中一个前面还有字母
                if(i >= 0 || j >= 0)
                {
                    return false;
                }
            }
            i--;
            j--;
        }

        return true;
    }

}