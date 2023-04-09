namespace String.模拟
{
    public class Long_Pressed_Name长按键入 {
        public bool IsLongPressedName(string name, string typed) {
            var n = name.Length;
            var m = typed.Length;
            int i = 0, j = 0;
            while(i < n && j < m)
            {
                if(name[i] == typed[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    // 第一位不同则直接返回
                    if(j == 0)
                    {
                        return false;
                    }
                    while( j < m - 1 && typed[j] == typed[j - 1])
                    {
                        j++;
                    }
                    // 跨越重复项后再进行匹配
                    if(name[i] == typed[j])
                    {
                        i++;
                        j++;
                    }else
                    {
                        return false;
                    }
                }
            }

            // name没匹配完
            if(i < n)
            {
                return false;
            }

            // type没匹配完
            while(j < m)
            {
                if(typed[j] != typed[j - 1])
                {
                    return false;
                }else{
                    j++;
                }
            }

            return true;
        }
    }
}