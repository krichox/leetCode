namespace String.模拟
{
    /*https://leetcode.cn/problems/robot-bounded-in-circle/description/*/
    public class 困于环中的机器人 {
        // 只有最后朝向北，且不为远点时才不会回到起点
        public bool IsRobotBounded(string instructions) {
            var direct = new[] {new []{1,0}, new[]{0,1}, new []{-1, 0}, new int[]{0, -1}};
            int x = 0, y = 0;
            var index = 0;

            for(var i = 0; i < instructions.Length; i++)
            {
                var instru = instructions[i];

                if(instru == 'G')
                {
                    x += direct[index][0];
                    y += direct[index][1];
                }else if(instru == 'L')
                {
                    index += 3;
                    index %= 4;
                }else
                {
                    index+= 1;
                    index %= 4;
                }
            }

            return x == 0 && y == 0 || index != 0;
        }
    }
}