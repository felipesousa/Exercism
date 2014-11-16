using System.Collections.Generic;
using System.Linq;

public class Complement
{
    private const char ADENINE   = 'A';
    private const char CYTOSINE  = 'C';
    private const char GUANINE   = 'G';
    private const char THYMIDINE = 'T';
    private const char URACIL    = 'U';

    private static readonly Dictionary<char, char> _complements = new Dictionary<char, char>
    {
        {GUANINE, CYTOSINE},
        {CYTOSINE, GUANINE},
        {THYMIDINE, ADENINE},
        {ADENINE, URACIL}
    };

    public static string OfDna(string dna)
    {
        return new string( dna.Select(RnaComplement).ToArray() );
    }

    public static string OfRna(string rna)
    {
        return new string(rna.Select(DnaComplement).ToArray());
    }

    private static char RnaComplement(char dna)
    {
        return _complements[dna];
    }

    private static char DnaComplement(char rna)
    {
        return (from pair in _complements where pair.Value == rna select pair.Key).FirstOrDefault();
    }
}