// This file was auto-generated based on version 1.1.0 of the canonical data.

using NUnit.Framework;

public class TwoFerTest
{
    [Test]
    public void No_name_given()
    {
        Assert.AreEqual("One for you, one for me.", TwoFer.Name());
    }

    [Test]
    public void A_name_given()
    {
        Assert.AreEqual("One for Alice, one for me.", TwoFer.Name("Alice"));
    }

    [Test]
    public void Another_name_given()
    {
        Assert.AreEqual("One for Bob, one for me.", TwoFer.Name("Bob"));
    }
}