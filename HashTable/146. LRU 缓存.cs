using System.Collections;
using System.Collections.Generic;

namespace HashTable
{
    /*https://leetcode.cn/problems/lru-cache/description/*/
    public class LRUCache
    {
        public class Node
        {
            public int Key;
            public int Value;
            public Node Prev;
            public Node Next;
        }

        private int capacity;
        private Node head;
        private Node tail;
        private Dictionary<int, Node> LRUDic;
        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            head = new Node();
            tail = new Node();
            head.Next = tail;
            tail.Prev = head;
            LRUDic = new Dictionary<int, Node>();
        }
    
        public int Get(int key)
        {
            if (LRUDic.ContainsKey(key))
            {
                var value = LRUDic[key].Value;
                DeleteNode(LRUDic[key]);
                AddNodeToHead(LRUDic[key]);
                return value;
            }else
            {
                // 如果不包含
                    return -1;
            }
            
  
        }
    
        public void Put(int key, int value) {
            // 如果包含这个key，则需要将这个值移到双向链表的头部
            if (LRUDic.ContainsKey(key))
            {
                var node = LRUDic[key];
                DeleteNode(node);
                node.Value = value;
                AddNodeToHead(node);
                return;
            }

            if (capacity > LRUDic.Count)
            {
                var node = new Node {Key = key, Value = value};
                AddNodeToHead(node);
                LRUDic.Add(key, node);
            }
            // 需要删除尾部元素，再添加
            else
            {
                var node = LRUDic[tail.Prev.Key];
                var deleteKey = DeleteTail();
                LRUDic.Remove(deleteKey);
                node.Key = key;
                node.Value = value;
                AddNodeToHead(node);
                LRUDic.Add(key, node);
            }
        }

        private int DeleteTail()
        {
            var key = tail.Prev.Key;
            var node = tail.Prev;
            node.Prev.Next = tail;
            node.Next.Prev = node.Prev;
            return key;
        }

        private void AddNodeToHead(Node node)
        {
            node.Next = head.Next;
            head.Next.Prev = node;
            head.Next = node;
            node.Prev = head;
        }

        private void DeleteNode(Node node)
        {
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
        }
    }
}