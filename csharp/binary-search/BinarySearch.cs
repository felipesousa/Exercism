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
        int length = _input.Length;
        int offset = 0;
        while(length > 0)
        {
            int index = (length - 1) / 2 + offset;
            if(_input[index] == value)
                return index;

            if(_input[index] > value)
            {
                length = index - offset;
            }
            else
            {
                length = _input.Length - index - 1;
                offset = index + 1;
            }
        }
        return -1;
    }
}