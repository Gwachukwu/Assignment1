using CalculatorUtility;
namespace CalculatorAPISubtractTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void ShouldReturn11()
    {
        decimal result = Calculator.Subtract(20, 9);
        Assert.AreEqual(11, result);
    }
    [TestMethod]
    public void ShouldReturnMinus10()
    {
        decimal result = Calculator.Subtract(10, 20);
        Assert.AreEqual(-10, result);
    }
    [TestMethod]
    public void ShouldReturn6()
    {
        decimal result = Calculator.Subtract(10, 4);
        Assert.AreEqual(6, result);
    }
    [TestMethod]
    public void ShouldReturn120()
    {
        decimal result = Calculator.Subtract(150, 30);
        Assert.AreEqual(120, result);
    }

    [TestMethod]
    public void ShouldReturn60()
    {
        decimal result = Calculator.Subtract(100, 40);
        Assert.AreEqual(60, result);
    }
}