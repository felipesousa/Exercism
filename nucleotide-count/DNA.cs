using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DNA
{
    /// <summary>
    /// Constructs the DNA
    /// </summary>
    /// <param name="dnaString">The string representation of the nucleotides</param>
    public DNA(string dnaString)
    {
        if(dnaString == null) throw new ArgumentNullException("dnaString");        
    }

    /// <summary>
    /// Gets a list of the nucleotide counts
    /// </summary>
    public IDictionary<char, int> NucleotideCounts { get; private set; }
    
    /// <summary>
    /// Gets the count of a particular nucleotide
    /// </summary>
    /// <param name="nucleotide">The nucleotide to count</param>
    /// <returns>The number of this nucleotide in this DNA</returns>
    public uint Count(char nucleotide)
    {
        return 0;
    }
}

/// <summary>
/// The exception thrown when requesting a count of an invalid nucleotide
/// </summary>
public class InvalidNucleotideException : Exception
{
}
