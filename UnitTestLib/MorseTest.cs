using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;


[TestClass]
public class PossibilitiesTest
{
    [TestMethod]
    public void ASingleSignal()
    {
        Assert.AreEqual(new List<string> { "E" }, Morse.Possibilities("."));
        Assert.AreEqual(new List<string> { "A" }, Challenge.Possibilities(".-"));
    }
    [TestMethod]
    public void AWordWithASingleUnknownSignal()
    {
        Assert.AreEqual(new List<string> { "E", "T" }, Challenge.Possibilities("?"));
        Assert.AreEqual(new List<string> { "I", "N" }, Challenge.Possibilities("?."));
        Assert.AreEqual(new List<string> { "I", "A" }, Challenge.Possibilities(".?"));
    }
}