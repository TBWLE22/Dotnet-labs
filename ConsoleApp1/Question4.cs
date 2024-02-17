using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result
{
    public class Question4
    {
        public void Calcresult()
        {
            const int passMarks = 35;
            const int fullMarks = 100;
            bool passed = true;

            int[] marks = new int[5];

            for (int i=0; i < 5; i++) 
            {
                Console.WriteLine($"Enter the marks for subject {i +1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int mark in marks)
            {
                if (mark < passMarks)
                {
                    passed = false;
                    break;
                }
            } 

            if (passed)
            {
                int totalMarks = 0;
                foreach (int mark in marks)
                {
                    totalMarks = totalMarks + mark; 
                }
                double percentage = (double)totalMarks / (5 * fullMarks)*100;
                Console.WriteLine($"Percentage: {percentage}%");

                if (percentage >= 60)
                {
                    Console.WriteLine("Division: First");
                }
                else if (percentage >= 45)
                {
                    Console.WriteLine("Division: Second");
                }
                else if (percentage >= 35)
                {
                    Console.WriteLine("Division: Third");
                }
            }
            else
            {
                Console.WriteLine("Try passing all the subjects next time.");
            }
        }
    }
}
