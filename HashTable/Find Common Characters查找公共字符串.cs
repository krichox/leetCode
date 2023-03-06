namespace HashTable {}

public class 查找公共字符串
{
    public IList<string> CommonChars(string[] words)
    {
        var result = new List<string>();
        if (words.Length <= 0)
        {
            return result;
        }

        // 第一个字符串，做初始化
        var hash = new int[26];
        for (var i = 0; i < words[0].Length; i++)
        {
            hash[words[0][i] - 'a']++;
            ;
            // result.Add(( words[0][i] - 'a').ToString());
        }

        for (var i = 1; i < words.Length; i++)
        {
            var array = new int[26];

            for (var j = 0; j < words[i].Length; j++)
            {
                array[words[i][j] - 'a']++;
            }

            for (var x = 0; x < 26; x++)
            {
                hash[x] = Math.Min(hash[x], array[x]);
            }
        }

        for (var i = 0; i < 26; i++)
        {
            while (hash[i] > 0)
            {
                var c = Convert.ToChar(i + 'a');
                result.Add(c.ToString());
                hash[i] -= 1;
            }
        }

        return result;
    }
}