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
        var keyBuilder = new StringBuilder();
        for(int i = 0; i < 100; i++)
        {
            char k = (char)('a' + _random.Next(26));
            keyBuilder.Append(k);
        }
        Key = keyBuilder.ToString();
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
}
