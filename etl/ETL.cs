﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ETL
{
    /// <summary>
    /// Transforms from the old scoring format to the new format
    /// </summary>
    /// <param name="input">The old data format</param>
    /// <returns>The new data format</returns>
    public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> input)
    {
        var output = new Dictionary<string, int>();
        foreach(var pair in input)
        {
            foreach(var letter in pair.Value)
            {
                output[letter.ToLower()] = pair.Key;
            }
        }
        return output;
    }
}
