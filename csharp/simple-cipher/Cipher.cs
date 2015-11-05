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

    public string Encode(string plaintext)
    {
        var ciphertext = new StringBuilder(plaintext.Length);
        for(int i = 0; i < plaintext.Length; i++)
        {
            char p = plaintext[i];
            char k = SubtractChar(Key[i], 'a');
            char c = AddChar(p, k);
            ciphertext.Append(c);
        }
        return ciphertext.ToString();
    }

    public string Decode(string ciphertext)
    {
        var plaintext = new StringBuilder(ciphertext.Length);
        for(int i = 0; i < ciphertext.Length; i++)
        {
            char c = ciphertext[i];
            char k = SubtractChar(Key[i], 'a');
            char p = SubtractChar(c, k);
            plaintext.Append(p);
        }
        return plaintext.ToString();
    }

    IEnumerable<char> RandomKeys()
    {
        while(true)
            yield return AddChar('a', (char)_random.Next(26));
    }

    char SubtractChar(char a, char b) => (char)(a - b);

    char AddChar(char a, char b) => (char)(a + b);
}
