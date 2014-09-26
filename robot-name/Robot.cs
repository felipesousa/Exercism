using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Robot
{
    private static Random _random = new Random();

    /// <summary>
    /// Creates a new robot
    /// </summary>
    public Robot()
    {
        GenerateRandomName();
    }

    /// <summary>
    /// The name of this robot
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Resets the robot, giving it a new name
    /// </summary>
    public void Reset()
    {
        GenerateRandomName();
    }

    private void GenerateRandomName()
    {
        Name = string.Format("{0}{1}{2}{3}{4}",
                                GetRandomLetter(),
                                GetRandomLetter(),
                                GetRandomDigit(),
                                GetRandomDigit(),
                                GetRandomDigit()
                            );
    }

    private char GetRandomLetter()
    {
        return (char)('A' + _random.Next(26));
    }

    private char GetRandomDigit()
    {
        return (char)('0' + _random.Next(10));
    }
}
