using CalculatorUtility;
namespace CalculatorAPIModuloTest;

[TestClass]
public class ModuloUnitTest
{
    [TestMethod]
    public void ShouldReturn1()
    {
        decimal result = Calculator.Modulo(3, 2);
        Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void ShouldReturn2()
    {
        decimal result = Calculator.Modulo(32, 10);
        Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void ShouldReturn3()
    {
        decimal result = Calculator.Modulo(10, 7);
        Assert.AreEqual(3, result);

    }
    [TestMethod]
    public void ShouldReturn4()
    {
        decimal result = Calculator.Modulo(24, 5);
        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void ShouldReturn5()
    {
        decimal result = Calculator.Modulo(17, 6);
        Assert.AreEqual(5, result);
    }
}