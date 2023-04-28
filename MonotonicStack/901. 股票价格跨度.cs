using System.Collections.Generic;

namespace MonotonicStack
{
    /*https://leetcode.cn/problems/online-stock-span/description/*/
    // 单调栈
    public class 股票价格跨度 {
        private readonly Stack<int[]> _stack;
        public 股票价格跨度() {
            _stack = new Stack<int[]>();
        }
    
        public int Next(int price) {
            if(_stack.Count == 0)
            {
                _stack.Push(new int[]{price, 1});
                return 1;
            }else if(price < _stack.Peek()[0])
            {
                _stack.Push(new int[]{price, 1});
                return 1;
            }else
            {
                var res = 1;
                while( _stack.Count != 0 && price >= _stack.Peek()[0] )
                {
                    res += _stack.Pop()[1];
                }
                _stack.Push(new int[]{price, res});
                return res;
            }
        }
    }
}