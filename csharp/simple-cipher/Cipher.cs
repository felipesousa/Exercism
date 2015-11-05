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
        return plaintext;
    }

    public string Decode(string ciphertext)
    {
        return ciphertext;
    }

    IEnumerable<char> RandomKeys()
    {
        while(true)
            yield return (char)('a' + _random.Next(26));
    }
}
