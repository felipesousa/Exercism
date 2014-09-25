using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DNA
{
    private const char ADENINE  = 'A';
    private const char CYTOSINE = 'C';
    private const char GUANINE  = 'G';
    private const char THYMINE  = 'T';
    private static char[] NUCLEOTIDES = new[] {
        ADENINE, CYTOSINE, GUANINE, THYMINE
    };

    /// <summary>
    /// Constructs the DNA
    /// </summary>
    /// <param name="dnaString">The string representation of the nucleotides</param>
    public DNA(string dnaString)
    {
        if(dnaString == null) throw new ArgumentNullException("dnaString");
        Initialize(dnaString);
    }

    /// <summary>
    /// Gets a list of the nucleotide counts
    /// </summary>
    public ImmutableDictionary<char, uint> NucleotideCounts { get; private set; }
    
    /// <summary>
    /// Gets the count of a particular nucleotide
    /// </summary>
    /// <param name="nucleotide">The nucleotide to count</param>
    /// <returns>The number of this nucleotide in this DNA</returns>
    public uint Count(char nucleotide)
    {
        nucleotide = ValididateNucleotide(nucleotide);
        if(!NucleotideCounts.ContainsKey(nucleotide))
            return 0;
        return NucleotideCounts[nucleotide];
    }

    private void Initialize(string dnaString)
    {
        var counts = ImmutableDictionary<char, uint>.Empty.ToBuilder();

        foreach(char nucleotide in NUCLEOTIDES)
            counts[nucleotide] = 0;

        foreach(char nucleotide in dnaString.Select(c => ValididateNucleotide(c)))
            counts[nucleotide]++;

        NucleotideCounts = counts.ToImmutable();
    }

    private char ValididateNucleotide(char nucleotide)
    {
        nucleotide = (from n in NUCLEOTIDES
                      where n == Char.ToUpper(nucleotide)
                      select n).FirstOrDefault();

        if(nucleotide == default(char))
            throw new InvalidNucleotideException(nucleotide);
        return nucleotide;
    }
}

/// <summary>
/// The exception thrown when requesting a count of an invalid nucleotide
/// </summary>
public class InvalidNucleotideException : Exception
{
    public InvalidNucleotideException()
        : base("Invalid nucleotide")
    {
    }

    public InvalidNucleotideException(char nucleotide) 
        : base(string.Format("{0} is not a valid nucleotide", nucleotide))
    {
    }
}
