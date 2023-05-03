namespace OtherProject
{
    /*https://leetcode.cn/problems/utf-8-validation/description/*/
    public class UTF_8_编码验证 {
        public bool ValidUtf8(int[] data) {
            var len = data.Length;
            if(data.Length == 1 && (data[0] >> 7 & 1)== 1)
            {
                return false;
            }

            // 模拟
            for(var i = 0; i < data.Length;)
            {
                var j = 7;
                while(j >= 0 && (((data[i] >> j) & 1) == 1))
                {
                    j--;
                }
                var cnt = 7 - j;
                // 如果为1或者大于4不合法
                if(cnt == 1 || cnt > 4)
                {
                    return false;
                }

                if(i + cnt - 1 >= len)
                {
                    return false;
                }

                // 进一步判断[i + 1, i + cnt]
                for(var k = i + 1; k < i + cnt; k++)
                {
                    if(((data[k] >> 7) & 1) == 1 && ((data[k] >> 6) & 1) == 0)
                    {
                        continue;
                    }
                    return false;
                }
                if(cnt == 0)
                {
                    i++;
                }else
                {
                    i += cnt;
                }
            }

            return true;
        }
    }
}