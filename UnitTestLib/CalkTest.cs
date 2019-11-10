using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskLib;

[TestClass]
public class CalcTest
{
    [TestMethod]
    public void ShouldHandleAddition()
    {
        Assert.AreEqual(2, Calk.Equals("1+1"), 1e-15);
    }
    [TestMethod]
    public void ShouldHandleSubtraction()
    {
        Assert.AreEqual(0, Calk.Calc("1 - 1"), 1e-15);
    }
    [TestMethod]
    public void ShouldHandleMultiplication()
    {
        Assert.AreEqual(1, Calk.Calc("1* 1"), 1e-15);
        Assert.AreEqual(1476, Calk.Calc("12* 123"), 1e-15);
    }
}