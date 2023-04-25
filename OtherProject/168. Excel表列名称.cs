using System.Linq;
using System.Text;

namespace OtherProject
{
    /*https://leetcode.cn/problems/excel-sheet-column-title/description/*/
    public class Excel表列名称 {
        public string ConvertToTitle(int columnNumber) {
            var result = new StringBuilder();
            while(columnNumber > 0)
            {
                columnNumber--;

                result.Append((char)(columnNumber % 26 + 'A'));
                columnNumber /= 26;
            }
        
            return new string(result.ToString().Reverse().ToArray());
        }
    }
}