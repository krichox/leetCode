namespace Backtracking.棋盘
{
    /*https://leetcode.cn/problems/n-queens-ii/description/*/
    public class N_皇后_II {
    int result = 0;
    public int TotalNQueens(int n) {
        var boards = new bool[n, n];
        dfs(boards, 0, n);
        return result;
    }

    void dfs(bool[,] boards, int raw, int n)
    {
        // end condition
        if(raw == n)
        {
            result++;
            return;
        }

        for(var i = 0; i < n; i++)
        {
            if(IsValid(boards, raw, i))
            {
                boards[raw, i] = true;
                dfs(boards, raw + 1, n);
                boards[raw, i] = false;
            }
        }

        bool IsValid(bool[,] boards, int raw, int col)
        {
            // 不需要检查行，一行只会选择一个
            // 列是否合法s
            for(var i = 0; i < raw; i++)
            {
                if(boards[i, col])
                {
                    return false;
                }
            }

            // 45度角
            for(int i = raw - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if(boards[i, j])
                {
                    return false;
                }
            }

            for(int i = raw - 1, j = col + 1; i >= 0 && j < n; i--, j++)
            {
                if(boards[i, j])
                {
                    return false;
                }
            }

            return true;
        }
    }
    }
}