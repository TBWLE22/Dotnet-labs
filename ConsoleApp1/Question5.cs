using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace simpleArithmetic
{
    public class Question5
    {
        public void math()
        {
            double a, b;
            Console.WriteLine("Enter the first number:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select one of the options among (+  -  *  /)");
            char choice = Convert.ToChar(Console.ReadLine());

            double result = 0;
            switch (choice)
            {
                case '+':
                    result = a + b;
                    Console.WriteLine($"Sum: {result}");
                    break;
                case '-':
                    result = a - b;
                    Console.WriteLine($"Difference: {result}");
                    break;
                case '*':
                    result = a * b;
                    Console.WriteLine($"Product:{result}");
                    break;
                case '/':
                    result = a / b;
                    Console.WriteLine($"Quotient:{result}");
                    break;
                default: 
                    Console.WriteLine("Invalid operator.");
                    break;
            }
        }
    }
}
