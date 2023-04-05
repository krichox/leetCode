namespace Backtracking
{
    /*https://leetcode.cn/problems/sudoku-solver/description/
     Write a program to solve a Sudoku puzzle by filling the empty cells.

A sudoku solution must satisfy all of the following rules:

Each of the digits 1-9 must occur exactly once in each row.
Each of the digits 1-9 must occur exactly once in each column.
Each of the digits 1-9 must occur exactly once in each of the 9 3x3 sub-boxes of the grid.
The '.' character indicates empty cells.

 

Example 1:


Input: board = [["5","3",".",".","7",".",".",".","."],["6",".",".","1","9","5",".",".","."],[".","9","8",".",".",".",".","6","."],["8",".",".",".","6",".",".",".","3"],["4",".",".","8",".","3",".",".","1"],["7",".",".",".","2",".",".",".","6"],[".","6",".",".",".",".","2","8","."],[".",".",".","4","1","9",".",".","5"],[".",".",".",".","8",".",".","7","9"]]
Output: [["5","3","4","6","7","8","9","1","2"],["6","7","2","1","9","5","3","4","8"],["1","9","8","3","4","2","5","6","7"],["8","5","9","7","6","1","4","2","3"],["4","2","6","8","5","3","7","9","1"],["7","1","3","9","2","4","8","5","6"],["9","6","1","5","3","7","2","8","4"],["2","8","7","4","1","9","6","3","5"],["3","4","5","2","8","6","1","7","9"]]
Explanation: The input board is shown above and the only valid solution is shown below:

*/
    public class Sudoku_Solver解速独 {
        public void SolveSudoku(char[][] board) {
            BackTracing(board);
        }

        //找到一个就返回结果，不需要遍历所有可能性 
        bool BackTracing(char[][] board)
        {

            // 二维递归
            for(var i = 0; i < board.Length; i++)
            {
                for(var j = 0; j < board[0].Length; j++)
                {
                    if(board[i][j] == '.')
                    {
                        for(var k = '1'; k <= '9'; k++)
                        {
                            if(IsValid(board, i, j, k))
                            {
                                board[i][j] = k;
                                if(BackTracing(board))
                                {
                                    return true;
                                }
                                board[i][j] = '.';
                            }
                        }
                        return false;
                    }
                }
            }

            return true;
        }

        bool IsValid(char[][] board, int raw, int col, char value)
        {
            // 判断行
            for(var i = 0; i < 9; i++)
            {
                if(board[raw][i] == value)
                {
                    return false;
                }
            }

            // 判断列
            for(var i = 0; i < 9; i++)
            {
                if(board[i][col] == value)
                {
                    return false;
                }
            }

            int startRaw = (raw / 3) * 3;
            int startCol = (col / 3) * 3;
            for(var i = startRaw; i < startRaw + 3; i++)
            {
                for(var j = startCol; j < startCol + 3; j++ )
                {
                    if(board[i][j] == value)
                    {
                        return false;
                    } 
                }
            }

            return true;
        }
        
    }
}