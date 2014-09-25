using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Phrase
{
    private readonly string _phrase;

    public Phrase(string phrase)
    {
        if (phrase == null) throw new ArgumentNullException("phrase");
        _phrase = phrase;
    }

    /// <summary>
    /// Gets a word count on this phrase
    /// </summary>
    /// <returns>The count of each unique word</returns>
    public IDictionary<string, int> WordCount()
    {
        var counts = new Dictionary<string, int>();
        var sanitized = SanitizeString(_phrase);
        var split = sanitized.Split(new []{ ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);
        foreach(string word in split)
        {
            if(counts.ContainsKey(word))
            {
                counts[word]++;
            }
            else
            {
                counts[word] = 1;
            }
        }
        return counts;
    }
    
    /// <summary>
    /// Cleans up a given string and prepares it for processing
    /// </summary>
    /// <param name="str">The string to sanatize</param>
    /// <returns>The string stripped of everything except, numbers,
    /// letters, commas and conjunctions.</returns>
    private static string SanitizeString(string str)
    {
        var sanitized = from c in str
                        where Char.IsLetterOrDigit(c) ||
                              Char.IsWhiteSpace(c) ||
                              c == '\'' ||
                              c == ','
                        select Char.ToLower(c);
        return new string(sanitized.ToArray());
    }
}
