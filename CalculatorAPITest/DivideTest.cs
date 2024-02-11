using CalculatorUtility;
namespace CalculatorAPIDivideTest;

[TestClass]
public class DivideUnitTest
{
    [TestMethod]
    public void ShouldReturn5()
    {
        decimal result = Calculator.Divide(5, 1);
        Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void ShouldReturn10()
    {
        decimal result = Calculator.Divide(50, 5);
        Assert.AreEqual(10, result);
    }
    [TestMethod]
    public void ShouldReturnZeroPoint2()
    {
        decimal result = Calculator.Divide(1m, 5m);
        Assert.AreEqual(0.2m, result);

    }
    [TestMethod]
    public void ShouldReturn12()
    {
        decimal result = Calculator.Divide(24, 2);
        Assert.AreEqual(12, result);
    }

    [TestMethod]
    public void ShouldReturn3()
    {
        decimal result = Calculator.Divide(9, 3);
        Assert.AreEqual(3, result);
    }
}