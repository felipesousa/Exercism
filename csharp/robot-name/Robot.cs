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
        Name = string.Format("{0}{1}{2:000}",
                                GetRandomLetter(),
                                GetRandomLetter(),
                                GetRandomDigits()
                            );
    }

    /// <summary>
    /// Gets a random letter from A to Z
    /// </summary>
    private char GetRandomLetter()
    {
        return (char)('A' + _random.Next(26));
    }

    /// <summary>
    /// Gets a random three digit number
    /// </summary>
    private int GetRandomDigits()
    {
        return _random.Next(1000);
    }
}
