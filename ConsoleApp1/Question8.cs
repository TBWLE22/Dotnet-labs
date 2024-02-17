using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minmax
{
    public class Question8
    {
        public void min_max_find()
        {
            Console.WriteLine("Enter the size of Array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine($"Enter {n} integer values:");
            for (int i =0; i < n ; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = numbers.Max();
            int min = numbers.Min();
            Console.WriteLine($"Min ={min}");
            Console.WriteLine($"Max ={max}");
        }
    }
}
