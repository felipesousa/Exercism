using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Hamming
{
    /// <summary>
    /// Calculate the Hamming difference between two DNA strands.
    /// </summary>
    /// <param name="dna1">DNA strand one</param>
    /// <param name="dna2">DNA strand two</param>
    /// <returns>The Hamming difference</returns>
    public static int Compute(string dna1, string dna2)
    {
        if(String.IsNullOrWhiteSpace(dna1)) throw new ArgumentException("Cannot be null or empty", "dna1");
        if(String.IsNullOrWhiteSpace(dna2)) throw new ArgumentException("Cannot be null or empty", "dna2");

        int diff = 0;
        for(int i = 0; i < dna1.Length && i < dna2.Length; i++)
        {
            if(dna1[i] != dna2[i]) diff++;
        }
        return diff;
    }
}
