```text
前置知识：集合论与位运算
集合可以用二进制表示，二进制从低到高第 iii 位为 111 表示 iii 在集合中，为 000 表示 iii 不在集合中。例如集合 {0,2,3}\{0,2,3\}{0,2,3} 对应的二进制数为 1101(2)1101_{(2)}1101 
(2)
​
 。

本题中用到的位运算技巧：

将元素 xxx 变成集合 {x}\{x\}{x}，即 1 << x。
判断元素 xxx 是否在集合 AAA 中，即 ((A >> x) & 1) == 1。
计算两个集合 A,BA,BA,B 的并集 A∪BA\cup BA∪B，即 A | B。例如 110 | 11 = 111。
计算 A∖BA \setminus BA∖B，表示从集合 AAA 中去掉在集合 BBB 中的元素，即 A & ~B。例如 110 & ~11 = 100。
全集 U={0,1,⋯ ,n−1}U=\{0,1,\cdots,n-1\}U={0,1,⋯,n−1}，即 (1 << n) - 1。
```
https://leetcode.cn/problems/smallest-sufficient-team/solutions/2214387/zhuang-ya-0-1-bei-bao-cha-biao-fa-vs-shu-qode/