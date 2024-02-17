using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterest
{
    public class Question2
    {
        public void simpleInterest()
        {
            Console.WriteLine("Enter the principal sum:");
            float p = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate:");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter time in years:");
            int t = Convert.ToInt32(Console.ReadLine());
            float SI = p * r * t;
            Console.WriteLine("The Simple Interest is " + SI);
        }
    }
}
