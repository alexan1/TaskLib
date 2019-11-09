using System.Collections.Generic;
using NUnit.Framework;
using System;
[TestFixture]
public class CalcTest
{
    [Test]
    public void ShouldHandleAddition()
    {
        Assert.AreEqual(2, Challenge.Calc("1+1"), 1e-15);
    }
    [Test]
    public void ShouldHandleSubtraction()
    {
        Assert.AreEqual(0, Challenge.Calc("1 - 1"), 1e-15);
    }
    [Test]
    public void ShouldHandleMultiplication()
    {
        Assert.AreEqual(1, Challenge.Calc("1* 1"), 1e-15);
        Assert.AreEqual(1476, Challenge.Calc("12* 123"), 1e-15);
    }
}