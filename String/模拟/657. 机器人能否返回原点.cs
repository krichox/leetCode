namespace String.模拟
{
    /*https://leetcode.cn/problems/robot-return-to-origin/description/*/
    public class 机器人能否返回原点 {
        public bool JudgeCircle(string moves) {
            var upDown = 0;
            var leftRight = 0;
            for(var i = 0; i < moves.Length; i++)
            {
                if(moves[i] == 'L')
                {
                    leftRight--;
                }else if(moves[i] == 'R' )
                {
                    leftRight++;
                }
                else if(moves[i] == 'U' )
                {
                    upDown++;
                }
                else if(moves[i] == 'D' )
                {
                    upDown--;
                }
            }

            return upDown == 0 && leftRight == 0;
        }
    }
}