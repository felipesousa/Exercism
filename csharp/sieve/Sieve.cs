using System.Collections.Generic;
using System.Linq;

public class Sieve
{
    // Once processes, false is prime, true is not prime
    private readonly bool[] _numbers;

    public Sieve(int max)
    {
        _numbers = new bool[max+1];
        _numbers[0] = true;
        _numbers[1] = true;
        int lastPrime = 2;
        while (lastPrime < max)
        {
            MarkNonPrimes(lastPrime);
            lastPrime = GetNextPrime(lastPrime);
        }
    }

    private void MarkNonPrimes(int multiple)
    {
        int max = _numbers.Length;
        int current = multiple*2;
        while (current < max)
        {
            _numbers[current] = true;
            current += multiple;
        }
    }

    private int GetNextPrime(int lastPrime)
    {
        for (int i = lastPrime + 1; i < _numbers.Length; i++)
        {
            if (!_numbers[i]) return i;
        }
        return _numbers.Length;
    }

    public IEnumerable<int> Primes
    {
        get
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                if (!_numbers[i]) yield return i;
            }
        }
    }
}