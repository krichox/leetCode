namespace String.模拟
{
    /*https://leetcode.cn/problems/validate-ip-address/description/*/
    public class 验证IP地址 {
    
        public string ValidIPAddress(string queryIP) {
            if(queryIP.IndexOf('.') >= 0 && validIpv4(queryIP))
            {
                return "IPv4";
            }

            if(queryIP.IndexOf(':') >= 0 && validIpv6(queryIP))
            {
                return "IPv6";
            }

            return "Neither";

        }

        private bool validIpv4(string queryIP)
        {
            var arr = queryIP.Split('.');
            var len = arr.Length;
            if(len != 4)
            {
                return false;
            }

            for(var i = 0; i < len; i++)
            {
                var curStr = arr[i];
                var n = curStr.Length;
                if(n < 1 || n > 3)
                {
                    return false;
                }
                if(curStr.StartsWith('0') && curStr.Length > 1)
                {
                    return false;
                }

                for(var j = 0; j < n; j++)
                {
                    if( !char.IsNumber(curStr[j]) )
                    {
                        return false;
                    }
                }

                if(int.Parse(curStr) < 0 || int.Parse(curStr) > 255)
                {
                    return false;
                }
            }

            return true;
        }

        private bool validIpv6(string queryIP)
        {
            var arr = queryIP.Split(':');
            var len = arr.Length;
            if(len != 8)
            {
                return false;
            }

            for(var i = 0; i < len; i++)
            {
                var curStr = arr[i];
                var n = curStr.Length;
                if(n < 1|| n > 4)
                {
                    return false;
                }

                for(var j = 0; j < n; j++)
                {
                    if(char.IsLetter(curStr[j]))
                    {
                        if(curStr[j] > 'f' || (curStr[j] > 'F' && curStr[j] < 'a'))
                        {
                            return false;
                        }
                    }else if(!char.IsNumber(curStr[j]))
                    {
                        return false;
                    }
                }
            }

            return true;

        }
    }
}