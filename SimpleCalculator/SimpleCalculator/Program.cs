using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InputConverter inputConverter = new InputConverter();//this class converts the users input
            CalculatorEngine calculatorEngine = new CalculatorEngine();//this class handles the calculation

            double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
            double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
            Console.WriteLine(result);
        }
    }
}
 