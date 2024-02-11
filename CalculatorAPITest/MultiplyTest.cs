using CalculatorUtility;
namespace CalculatorAPIMultiplyTest;

[TestClass]
public class MultiplyUnitTest
{
    [TestMethod]
    public void ShouldReturn14()
    {
        decimal result = Calculator.Multiply(2, 7);
        Assert.AreEqual(14, result);
    }
    [TestMethod]
    public void ShouldReturn25()
    {
        decimal result = Calculator.Multiply(5, 5);
        Assert.AreEqual(25, result);
    }
    [TestMethod]
    public void ShouldReturn6()
    {
        decimal result = Calculator.Multiply(1, 6);
        Assert.AreEqual(6, result);
    }
    [TestMethod]
    public void ShouldReturn0()
    {
        decimal result = Calculator.Multiply(70, 0);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void ShouldReturn500()
    {
        decimal result = Calculator.Multiply(250, 2);
        Assert.AreEqual(500, result);
    }
}