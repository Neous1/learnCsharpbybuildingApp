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
            CalculatorEngine calculatorEngine = new calculatorEngine();//this class handles the calculation

            double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine);
            double SecondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine);
            string operation = Console.ReadLine();
        }
    }
}
 