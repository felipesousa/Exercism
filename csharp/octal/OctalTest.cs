using NUnit.Framework;

[TestFixture]
public class OctalTest
{
    // change Ignore to false to run test case or just remove 'Ignore = "Todo"'
    [TestCase("1", ExpectedResult = 1)]
    [TestCase("10", ExpectedResult = 8, Ignore = "Todo")]
    [TestCase("17", ExpectedResult = 15, Ignore = "Todo")]
    [TestCase("11", ExpectedResult = 9, Ignore = "Todo")]
    [TestCase("130", ExpectedResult = 88, Ignore = "Todo")]
    [TestCase("2047", ExpectedResult = 1063, Ignore = "Todo")]
    [TestCase("7777", ExpectedResult = 4095, Ignore = "Todo")]
    [TestCase("1234567", ExpectedResult = 342391, Ignore = "Todo")]
    public int Octal_converts_to_decimal(string value)
    {
        return Octal.ToDecimal(value);
    }

    [TestCase("carrot", Ignore = "Todo")]
    [TestCase("8", Ignore = "Todo")]
    [TestCase("9", Ignore = "Todo")]
    [TestCase("6789", Ignore = "Todo")]
    [TestCase("abc1z", Ignore = "Todo")]
    public void Invalid_octal_is_decimal_0(string invalidValue)
    {
        Assert.That(Octal.ToDecimal(invalidValue), Is.EqualTo(0));
    }

    [Ignore("Todo")]
    [Test]
    public void Octal_can_convert_formatted_strings()
    {
        Assert.That(Octal.ToDecimal("011"), Is.EqualTo(9));
    }
}