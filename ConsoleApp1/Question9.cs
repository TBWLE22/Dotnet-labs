using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoDarray
{
    public class Question9
    {
        public void uppertriangulize()
        {
            int[,] matrix = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("     ");
                }
                for (int j = i; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]}    ");
                }
                Console.WriteLine(); 
            }
        }
    }
}

