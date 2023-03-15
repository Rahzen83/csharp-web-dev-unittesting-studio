namespace BalancedBracketsTests;
using BalancedBrackets;
using System;


[TestClass]
public class BalancedBracketsTests
{
    // TODO: Add tests to this file.

    [TestMethod]
    public void MismatchReturnsFalse()
    {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[string[]"));
    }

    [TestMethod]
    public void WrongOrderWithString()
    {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("str][ing"));
    }

    [TestMethod]
    public void BracketsInFront()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]String"));
    }

    [TestMethod]
    public void OnlyClosedBracketReturnsFalse()
    {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("string]"));
    }

    [TestMethod]
    public void OnlyOpenBracketReturnsFalse()
    {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[string"));
    }

    [TestMethod]
    public void StringAndBracketsReturnsTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
    }
        

    [TestMethod]
    public void StringInBracketReturnsTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
    }

    [TestMethod]
    public void BracketsInWrongOrder()
    {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
    }

    [TestMethod]
    public void OneBracketReturnsFalse()
    {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
    }

    [TestMethod]
    public void EmptyStringReturnsTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
    }
    [TestMethod] 
    public void OnlyBracketsReturnsTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
    }

    [TestMethod]
    public void EmptyTest()
    {
        Assert.AreEqual(true, true);
    }
}
