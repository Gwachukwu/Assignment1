using CalculatorUtility;
namespace CalculatorAPIAddTest;

[TestClass]
public class AddTest
{
    [TestMethod]
    public void ShouldReturn12()
    {
        decimal result = Calculator.Add(5, 7);
        Assert.AreEqual(12, result);
    }
    [TestMethod]
    public void ShouldReturn10()
    {
        decimal result = Calculator.Add(5, 5);
        Assert.AreEqual(10, result);
    }
    [TestMethod]
    public void ShouldReturn6()
    {
        decimal result = Calculator.Add(1, 5);
        Assert.AreEqual(6, result);
    }
    [TestMethod]
    public void ShouldReturn120()
    {
        decimal result = Calculator.Add(70, 50);
        Assert.AreEqual(120, result);
    }

    [TestMethod]
    public void ShouldReturn60()
    {
        decimal result = Calculator.Add(40, 20);
        Assert.AreEqual(60, result);
    }
}