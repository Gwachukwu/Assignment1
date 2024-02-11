using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CalculatorUtility;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        public decimal Add(decimal a, decimal b)
        {
            return Calculator.Add(a, b);
        }

        public decimal Subtract(decimal a, decimal b)
        {
            return Calculator.Subtract(a, b);
        }

        public decimal Multiply(decimal a, decimal b)
        {
            return Calculator.Multiply(a, b);
        }

        public decimal Divide(decimal a, decimal b)
        {
            return Calculator.Divide(a, b);
        }

        public decimal Modulo(decimal a, decimal b)
        {
            return Calculator.Modulo(a, b);
        }
    }
}
