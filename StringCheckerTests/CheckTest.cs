using TestApp;

namespace StringCheckerTests;

public class Tests
{
    [Test]
    [TestCase("success", "success", "Equal")]
    [TestCase("interview", "interview", "Equal")]
    public void EqualTest(string s, string t, string expected)
    {
        var actual = StringChecker.CheckString(s,t);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
    [TestCase("nice", "niece", "Insert e")]
    [TestCase("give", "giave", "Insert a")]
    public void InsertTest(string s, string t, string expected)
    {
        var actual = StringChecker.CheckString(s, t);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("form", "from", "Swap o r")]
    [TestCase("for", "fro", "Swap o r")]
    public void SwapTest(string s, string t, string expected)
    {
        var actual = StringChecker.CheckString(s, t);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("test", "tent", "Replace s n")]
    [TestCase("zeus", "zeas", "Replace u a")]
    public void ReplaceTest(string s, string t, string expected)
    {
        var actual = StringChecker.CheckString(s,t);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("o", "odd", "Impossible")]
    [TestCase("e", "even", "Impossible")]
    public void ImpossibleTest(string s, string t, string expected)
    {
        var actual = StringChecker.CheckString(s,t);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
}