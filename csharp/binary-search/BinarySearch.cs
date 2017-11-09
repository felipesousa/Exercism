using System;
using System.Linq;

public class BinarySearch
{
    int[] _input;

    public BinarySearch(int[] input)
    {
        _input = input;
    }

    public int Find(int value)
    {
        int[] search = _input;
        int offset = 0;
        while(search.Length > 0)
        {
            int index = search.Length / 2;
            if(search[index] == value)
                return index + offset;

            if(search[index] > value)
            {
                search = search.Take(index).ToArray();
            }
            else
            {
                search = search.Skip(index+1).ToArray();
                offset += index+1;
            }
        }
        return -1;
    }
}