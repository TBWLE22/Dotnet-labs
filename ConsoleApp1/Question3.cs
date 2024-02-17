using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qudraticroots
{
    public class Question3
    {
        public void quadraticEqn()
        {
            int a, b, c;
            double d, x1, x2;

            Console.WriteLine("Enter the value of a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the value of b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the value of c:");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c; //Calculating the discriminant

            if (d == 0)
            {
                Console.Write("Both roots are equal.\n");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("First Root is {0}\n", x1);
                Console.Write("Second Root is {0}\n", x2);
            }
            else if(d > 0)
            {
                Console.WriteLine("Both roots are real and different.\n");

                x1 = (-b + Math.Sqrt(d))/(2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.Write("First Root is {0}\n", x1);
                Console.Write("Second Root is {0}\n", x2);
            }
            else 
            {
                Console.WriteLine("The roots are imaginary.\n");
            }
        }

    }
}
