namespace LinkedList
{
    public class DesignLinkedList
    {
        public class ListNode
        {
            internal readonly int Val;
            internal ListNode Next;

            public ListNode(int val)
            {
                this.Val = val;
            }

            public ListNode(int val, ListNode next)
            {
                this.Val = val;
                this.Next = next;
            }
        }

        public class MyLinkedList
        {
            int size;

            ListNode head;

            public MyLinkedList()
            {
                size = 0;
                // 哨兵指针, 虚指针
                head = new ListNode(0);
            }

            public int Get(int index)
            {
                if (index < 0 || index >= size)
                {
                    return -1;
                }

                // 指针指向头部
                var cur = head;
                for (var i = 0; i <= index; i++)
                {
                    cur = cur.Next;
                }

                return cur.Val;
            }

            public void AddAtHead(int val)
            {
                AddAtIndex(0, val);
            }

            public void AddAtTail(int val)
            {
                AddAtIndex(size, val);
            }

            public void AddAtIndex(int index, int val)
            {
                if (index > size)
                {
                    return;
                }

                if (index < 0)
                {
                    index = 0;
                }

                var prev = head;
                // 得到具体插入点
                for (var i = 0; i < index; i++)
                {
                    prev = prev.Next;
                }

                var toBeAdd = new ListNode(val);
                toBeAdd.Next = prev.Next;
                prev.Next = toBeAdd;
                size++;
            }

            public void DeleteAtIndex(int index)
            {
                if (index < 0 || index >= size)
                {
                    return;
                }

                // 指向头部
                var prev = head;
                // 找到需要删除的node 前驱
                for (var i = 0; i < index; i++)
                {
                    // 向后移动
                    prev = prev.Next;
                }

                // delete node
                prev.Next = prev.Next.Next;
                size--;
            }
        }
    }



//双链表版本


/*public class ListNode{
    internal int val;
    internal ListNode prev;
    internal ListNode next;

    public ListNode(int val)
    {
        this.val = val;
    }
}

public class MyLinkedList {

    internal int size;

    // 虚头指针
    internal ListNode head;

    // 虚尾指针
    internal ListNode tail;
    public MyLinkedList() {
        size = 0;
        // 虚头指针
        head = new ListNode(0);
        tail = new ListNode(0);
        head.next = tail;
        tail.prev = head;

    }
    
    public int Get(int index) {
        if(index < 0 || index >= size)
        {
            return -1;
        }
        var cur = head;
        if(size - index > index)
        {
            // 头部移动,找到具体node
            for(var i = 0; i <= index; i++)
            {
                cur = cur.next;
            }
        }else
        {
            cur = tail;
            for(var i = size - index; i > 0; i--)
            {
                cur = cur.prev;
            }
        }

        return cur.val;
    }
    
    public void AddAtHead(int val) {
        var pred = head; 
        var succ = head.next;
        var toAdd = new ListNode(val);
        toAdd.prev = pred;
        toAdd.next = succ;
        pred.next = toAdd;
        succ.prev = toAdd;
        size++;
    }
    
    public void AddAtTail(int val) {
        var succ = tail;
        var pred = tail.prev;
        var toAdd = new ListNode(val);
        toAdd.prev = pred;
        toAdd.next = succ;
        pred.next = toAdd;
        succ.prev = toAdd;
        size++;
    }
    
    public void AddAtIndex(int index, int val) {
       if(index > size)
       {
           return;
       }

       if(index < 0)
       {
           index = 0;
       }

       ListNode pred;
       ListNode succ;
        if(size - index > index)
        {
            pred = head;
            for(var i = 0; i < index; i++)
            {
                pred = pred.next;
            }
            succ = pred.next;
        }else
        {
            succ = tail;
            for(var i = size - index;i > 0; i--)
            {
                succ = succ.prev;
            }
            pred = succ.prev;
        }
        var toAdd = new ListNode(val);
        toAdd.prev = pred;
        toAdd.next = succ;
        pred.next = toAdd;
        succ.prev = toAdd;
        size++;
    }
    
    public void DeleteAtIndex(int index) {
        if (index < 0 || index >= size) return;

        // find predecessor and successor of the node to be deleted
        ListNode pred;
        ListNode succ;
        if (index < size - index) {
            pred = head;
            for(int i = 0; i < index; ++i) pred = pred.next;
            succ = pred.next.next;
        }   
        else 
        {
            succ = tail;
            for (int i = 0; i < size - index - 1; ++i) 
            {
                succ = succ.prev;
            }
            pred = succ.prev.prev;
        }

        // delete pred.next 
        --size;
        pred.next = succ;
        succ.prev = pred;
        }
}*/
}