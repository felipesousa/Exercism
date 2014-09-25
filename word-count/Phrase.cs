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
        _phrase = phrase;
    }

    /// <summary>
    /// Gets a word count on this phrase
    /// </summary>
    /// <returns>The word count</returns>
    public Dictionary<string, int> WordCount()
    {
        var counts = new Dictionary<string, int>();

        return counts;
    }
}
