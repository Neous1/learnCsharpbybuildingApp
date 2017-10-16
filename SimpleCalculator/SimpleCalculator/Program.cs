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
            string input = Console.ReadLine();
            if (input.Equals("Avetis"))
            {
                Console.WriteLine("Hello Admin!");
            }
            else if (input.Equals("Joe"))
            {
                Console.WriteLine("Hello Moderator!");
            }
            else 
            {
                Console.WriteLine("Hello Guest!");
            }
        }
    }
}
