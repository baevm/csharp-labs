namespace lab1_csharp;

public abstract class WordCounter
{
    public static List<KeyValuePair<string, int>> Get(List<string> words)
    {
        var count = new Dictionary<string, int>();

        foreach (var word in words)
        {
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
}
