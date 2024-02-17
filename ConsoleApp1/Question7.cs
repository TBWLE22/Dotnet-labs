using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace alphabetorder
{
    public class Question7
    {
        public void sort_alphabet()
        {
            int n;
            Console.WriteLine("Enter the size of the array:");
            n = Convert.ToInt32(Console.ReadLine());
            string[] elements = new string[n];
            for (int i = 0; i < n;i++)
            {
                Console.WriteLine("Enter a few random meaningful strings:");
                elements[i] = Console.ReadLine();
            }
            Array.Sort(elements);
            Console.WriteLine("The alphabetically sorted elements in array:");
            foreach (string element in elements) 
            {
                    Console.WriteLine(element);
            }
        }
    }
}
