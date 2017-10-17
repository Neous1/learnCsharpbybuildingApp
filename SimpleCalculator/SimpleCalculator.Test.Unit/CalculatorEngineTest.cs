using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResutlForNonSymbolOperation()
        {
            //1. setting upthe data for unit test
            int number1 = 1;
                int number2 = 2;
            double result = _calculatorEngine.Calculate("add", number1, number2);

            //2. process the data thru the method that you want to test
            //3. compare the result from processing against your assumption
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResutlForSymbolOperation()
        {
            //1. setting upthe data for unit test
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("+", number1, number2);

            //2. process the data thru the method that you want to test
            //3. compare the result from processing against your assumption
            Assert.AreEqual(3, result);
        }
    }
}
