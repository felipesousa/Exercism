using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class BinaryTest
{
    // change Ignore to false to run test case or just remove 'Ignore = "Todo"'
    [TestCase("1", ExpectedResult = 1)]
    [TestCase("10", ExpectedResult = 2)]
    [TestCase("11", ExpectedResult = 3)]
    [TestCase("100", ExpectedResult = 4)]
    [TestCase("1001", ExpectedResult = 9)]
    [TestCase("11010", ExpectedResult = 26)]
    [TestCase("10001101000", ExpectedResult = 1128)]
    public int Binary_converts_to_decimal(string binary)
    {
        return new Binary(binary).ToDecimal();
    }

    [TestCase("carrot")]
    [TestCase("2")]
    [TestCase("5")]
    [TestCase("9")]
    [TestCase("134678")]
    [TestCase("abc10z")]
    public void Invalid_binary_is_decimal_0(string invalidValue)
    {
        Assert.That(new Binary(invalidValue).ToDecimal(), Is.EqualTo(0));
    }

    [Test]
    public void Binary_can_convert_formatted_strings()
    {
        Assert.That(new Binary("011").ToDecimal(), Is.EqualTo(3));
    }
}