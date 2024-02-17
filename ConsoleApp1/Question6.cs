using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace studentarr
{
    public class Question6
    {
        public void find_t()
        {
            string[] students = new string[4];
            for (int i = 0; i < students.Length; i++) 
            {
                Console.WriteLine($"Enter the name of student {i+1}:");
                students[i] = Console.ReadLine();
            }

            Console.WriteLine ("Students whose name contains 't':");
            foreach (string student in students)
            {
                if ( student.ToLower().Contains('t'))
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
