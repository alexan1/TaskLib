using System.Collections.Generic;
using NUnit.Framework;
using System;
[TestFixture]
public class CountChangeTest
{
    [Test]
    public void ShouldHandleTheExampleCase()
    {
        Assert.AreEqual(3, Challenge.CountChange(4, new int[] { 1, 2 }));
    }
    [Test]
    public void ShouldHandleAnotherSimpleCase()
    {
        Assert.AreEqual(4, Challenge.CountChange(10, new int[] { 5, 2, 3 }));
    }
}