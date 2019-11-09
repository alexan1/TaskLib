using System;
[TestFixture]
public class PossibilitiesTest
{
    [Test]
    public void ASingleSignal()
    {
        Assert.AreEqual(new List<string> { "E" }, Challenge.Possibilities("."));
        Assert.AreEqual(new List<string> { "A" }, Challenge.Possibilities(".-"));
    }
    [Test]
    public void AWordWithASingleUnknownSignal()
    {
        Assert.AreEqual(new List<string> { "E", "T" }, Challenge.Possibilities("?"));
        Assert.AreEqual(new List<string> { "I", "N" }, Challenge.Possibilities("?."));
        Assert.AreEqual(new List<string> { "I", "A" }, Challenge.Possibilities(".?"));
    }
}