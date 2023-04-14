using System.Collections.Generic;
using System.Linq;

namespace QueueStack
{
    /*Implement a last-in-first-out (LIFO) stack using only two queues. The implemented stack should support all the functions of a normal stack (push, top, pop, and empty).

Implement the MyStack class:

void push(int x) Pushes element x to the top of the stack.
int pop() Removes the element on the top of the stack and returns it.
int top() Returns the element on the top of the stack.
boolean empty() Returns true if the stack is empty, false otherwise.
Notes:

You must use only standard operations of a queue, which means that only push to back, peek/pop from front, size and is empty operations are valid.
Depending on your language, the queue may not be supported natively. You may simulate a queue using a list or deque (double-ended queue) as long as you use only a queue's standard operations.

Example 1:

Input
["MyStack", "push", "push", "top", "pop", "empty"]
[[], [1], [2], [], [], []]
Output
[null, null, null, 2, 2, false]

Explanation
MyStack myStack = new MyStack();
myStack.push(1);
myStack.push(2);
myStack.top(); // return 2
myStack.pop(); // return 2
myStack.empty(); // return False*/
    public class 用队列实现栈
    {
        private Queue<int> _queue;

        public 用队列实现栈() {
            _queue = new Queue<int>();
        }
    
        public void Push(int x) {
            var tempQueueList = _queue.ToList();
            while(_queue.Count != 0)
            {
                _queue.Dequeue();
            }

            _queue.Enqueue(x);
            tempQueueList.ForEach(x => _queue.Enqueue(x));
        }
    
        public int Pop() {
            return _queue.Dequeue();
        }
    
        public int Top() {
            return _queue.Peek();
        }
    
        public bool Empty() {
            return _queue.Count == 0;
        }
    }
}