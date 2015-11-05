using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cipher
{
    static Random _random = new Random();

    public Cipher() : this("d")
    {
        Key = new string(RandomKeys().Take(100).ToArray());
    }

    public Cipher(string key)
    {
        Key = key;
    }

    public string Key { get; set; }

    public string Encode(string plaintext) => Transform(plaintext, AddChar);

    public string Decode(string ciphertext) => Transform(ciphertext, SubtractChar);

    string Transform(string initial, Func<char, char, char> func)
    {
        var transformed = new StringBuilder(initial.Length);
        for(int i = 0; i < initial.Length; i++)
        {
            char c = initial[i];
            char k = SubtractChar(Key[i % Key.Length], 'a');
            char t = func(c, k);
            transformed.Append(t);
        }
        return transformed.ToString();
    }

    IEnumerable<char> RandomKeys()
    {
        while(true)
            yield return AddChar('a', (char)_random.Next(26));
    }

    char SubtractChar(char a, char b) => (char)(a - b);

    char AddChar(char a, char b) => (char)(a + b);
}
