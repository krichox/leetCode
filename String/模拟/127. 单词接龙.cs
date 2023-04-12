using System.Collections.Generic;

namespace String.模拟
{
    /*https://leetcode.cn/problems/word-ladder/*/
    public class 单词接龙 {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
            var queue =  new Queue<string>();
            var set = new HashSet<string>();
            var count = 1;
            queue.Enqueue(beginWord);
            LinkedList<int> a = new LinkedList<int>();
            while(queue.Count != 0)
            {
                var queueCount = queue.Count;
                for(var i = 0; i < queueCount; i++)
                {
                    var curWord = queue.Dequeue();
                    for(var j = 0; j < wordList.Count; j++)
                    {
                        if(canTransfer(curWord,wordList[j]) && !set.Contains(wordList[j]))
                        {
                            set.Add(wordList[j]);
                            if(wordList[j] == endWord)
                            {
                                return ++count;
                            }
                            queue.Enqueue(wordList[j]);
                        }
                    }
                }
                count++;
            }

            return 0;
        }

        bool canTransfer(string a, string b)
        {
            var count = 0;
            for(var i = 0; i < a.Length; i++)
            {
                if(a[i] != b[i])
                {
                    count++;
                }
            }

            return count <= 1;
        }
    }
}