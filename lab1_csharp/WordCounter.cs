using System.Text.RegularExpressions;

namespace lab1_csharp;

public abstract class WordCounter
{
    public static List<KeyValuePair<string, int>> Get(List<string> words)
    {
        var count = new Dictionary<string, int>();

        for (var i = 0; i < words.Count; i++)
        {
           var word = RemoveSpecialCharacters(words[i]);
            
            if (count.ContainsKey(word))
            {
                count[word] += 1;
            }
            else
            {
                count[word] = 1;
            }
        }

        return count.ToList();
    }
    
    private static string RemoveSpecialCharacters(string str)
    {
        return Regex.Replace(str, "[^a-zA-Z0-9_]+", "", RegexOptions.Compiled);
    }
}
