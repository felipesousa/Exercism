using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a North American phone number
/// </summary>
public class PhoneNumber
{
    /// <summary>
    /// Constructs a phone number from a string
    /// </summary>
    /// <param name="number">A string representation of a phone number</param>
    public PhoneNumber(string number)
    {
        Number = CleanPhoneNumber(number);
    }

    /// <summary>
    /// The sanitized version of the phone number.
    /// </summary>
    public string Number { get; private set; }

    /// <summary>
    /// Gets the area code portion of the phone number
    /// </summary>
    public string AreaCode { get { return Number; } }

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this Phone number.
    /// </summary>
    /// <returns>
    /// A formated phone number
    /// </returns>
    public override string ToString()
    {
        return base.ToString();
    }

    private static string CleanPhoneNumber(string number)
    {
        return number;
    }
}
