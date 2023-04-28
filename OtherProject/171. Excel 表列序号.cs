namespace OtherProject
{
    /*https://leetcode.cn/problems/excel-sheet-column-number/description/*/
    public class Excel_表列序号 {
        public int TitleToNumber(string columnTitle) {
            var res = 0;
        
            for(var i = 0; i < columnTitle.Length; i++)
            {
                res = 26 * res + (columnTitle[i] - 'A' + 1);
            }

            return res;
        }
    }
}