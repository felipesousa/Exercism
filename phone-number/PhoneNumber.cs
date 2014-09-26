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
    private const string NUMBER_FORMAT  = "({0}) {1}-{2}";
    private const string DEFAULT_NUMBER = "0000000000";
    /// <summary>
    /// Constructs a phone number from a string
    /// </summary>
    /// <param name="number">A string representation of a phone number</param>
    public PhoneNumber(string number)
    {
        CleanPhoneNumber(number);
    }

    /// <summary>
    /// The sanitized version of the phone number.
    /// </summary>
    public string Number { get; private set; }

    /// <summary>
    /// Gets the area code portion of the phone number
    /// </summary>
    public string AreaCode { get { return Number.Substring(0, 3); } }

    /// <summary>
    /// Gets the exchange code portion (second group of three digits) of the phone number.
    /// </summary>
    public string ExchangeCode { get { return Number.Substring(3, 3); } }

    /// <summary>
    /// Gets the subscriber number portion (last four digits) of the phone number.
    /// </summary>
    public string SubscriberNumber { get { return Number.Substring(6); } }

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this Phone number.
    /// </summary>
    /// <returns>
    /// A formated phone number
    /// </returns>
    public override string ToString()
    {
        return string.Format(NUMBER_FORMAT, AreaCode, ExchangeCode, SubscriberNumber);
    }

    private void CleanPhoneNumber(string number)
    {
        // Strip everything but numbers
        var digits = number.Where(c => char.IsDigit(c)).ToArray();
        var clean = new string(digits);
        if (clean.Length == 10)
        {
            Number = clean;
        }
        else if(clean.Length == 11 && clean[0] == '1')
        {
            Number = clean.Substring(1);
        }
        else
        {
            Number = DEFAULT_NUMBER;
        }
    }
}
