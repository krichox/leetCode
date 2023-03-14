using System;
using System.Collections.Generic;
using System.Text;

namespace Backtracking
{
    /*https://leetcode.cn/problems/n-queens/description/
     The n-queens puzzle is the problem of placing n queens on an n x n chessboard such that no two queens attack each other.

Given an integer n, return all distinct solutions to the n-queens puzzle. You may return the answer in any order.

Each solution contains a distinct board configuration of the n-queens' placement, where 'Q' and '.' both indicate a queen and an empty space, respectively.

 

Example 1:


Input: n = 4
Output: [[".Q..","...Q","Q...","..Q."],["..Q.","Q...","...Q",".Q.."]]
Explanation: There exist two distinct solutions to the 4-queens puzzle as shown above
Example 2:

Input: n = 1
Output: [["Q"]]*/
    public class N_QueensN皇后
    {
        private IList<IList<string>> result = new List<IList<string>>();

        public IList<IList<string>> SolveNQueens(int n)
        {

            var boards = new char[n][];

            for (var i = 0; i < boards.Length; i++)
            {
                boards[i] = new char[n];
            }

            foreach (var perBoard in boards)
            {
                for (var i = 0; i < perBoard.Length; i++)
                {
                    perBoard[i] = '.';
                }
            }

            BackTracing(boards, n, 0);

            return result;
        }


        /// <summary>
        ///  backTracing
        /// </summary>
        /// <param name="board"></param>
        /// <param name="n"></param>
        /// <param name="row">行</param>
        void BackTracing(char[][] board, int n, int row)
        {
            // end condition
            if (row == n)
            {
                result.Add(CharArrToListString(board));
                return;
            }

            for (var col = 0; col < n; col++)
            {
                if (isValid(row, col, n, board))
                {
                    board[row][col] = 'Q';
                    BackTracing(board, n, row + 1);
                    board[row][col] = '.';
                }
            }
        }

        private bool isValid(int raw, int col, int n, char[][] board)
        {
            // 检查列
            for (var i = 0; i < raw; i++)
            {
                if (board[i][col] == 'Q')
                {
                    return false;
                }
            }

            // 检查行
            for (int i = 0; i < col; i++)
            {
                if (board[raw][i] == 'Q')
                {
                    return false;
                }
            }

            // 检查45度角
            for (int i = raw - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i][j] == 'Q')
                {
                    return false;
                }
            }

            // 检查135度角
            for (int i = raw - 1, j = col + 1; i >= 0 && j <= n - 1; i--, j++)
            {
                if (board[i][j] == 'Q')
                {
                    return false;
                }

            }

            return true;
        }

        private List<string> CharArrToListString(char[][] board)
        {
            var arrToListString = new List<string>();
            for (var i = 0; i < board.Length; i++)
            {
                arrToListString.Add(string.Join("", board[i]));
            }

            return arrToListString;
        }
    }
}