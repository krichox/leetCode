using System;
using System.Text;

namespace String.模拟
{
    /*https://leetcode.cn/problems/masking-personal-information/*/
    public class Masking_Personal_Information隐藏个人信息 {
        public string MaskPII(string s) {
            var index = s.IndexOf('@');
            if(index != -1)
            {
                // email
                s = s.ToLower();
                var domainName = s[..index];
                string resultDomainName;
                var lower = domainName.ToLower();
                if(domainName.Length == 1)
                {
                    resultDomainName = lower[0] + "*****";
                }else
                {
                    resultDomainName = lower[0] + "*****" + lower[index - 1];
                }

                return string.Concat(resultDomainName, s[index..]);
            }

            var sb = new StringBuilder();
            foreach (var perChar in s)
            {
                if(char.IsDigit(perChar))
                {
                    sb.Append(perChar);
                }
            }
            var countryCount = sb.Length - 10;
            
            return  sb.Length > 10
                ? $"+{new string('*', countryCount)}-***-***-{sb.ToString()[(sb.Length - 4)..]}"
                : $"***-***-{sb.ToString()[(sb.Length - 4)..]}";
        }
    }
}