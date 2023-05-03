using System.Collections.Generic;

namespace LinkedList
{
    /*https://leetcode.cn/problems/copy-list-with-random-pointer/description/*/
    public class 复制带随机指针的链表 {
        public class Node {
            public int val;
            public Node next;
            public Node random;
    
            public Node(int _val) {
                val = _val;
                next = null;
                random = null;
            }
        }
        public Node CopyRandomList(Node head) {
            var dic = new Dictionary<Node, Node>();
            var cur = head;
            var dummy = new Node(-1);
            var p = dummy;
            while(cur != null)
            {
                var node = new Node(cur.val);

                dic.Add(cur, node);
            
                p.next = node;
                p = p.next;
                cur = cur.next;
            }


            p = dummy.next;
            cur = head;
            while(cur != null)
            {
                if(cur.random == null)
                {
                    p.random = null;
                }else
                {
                    p.random = dic[cur.random];
                }

                p = p.next;
                cur = cur.next;

            }

            return dummy.next;
        }
    }
}