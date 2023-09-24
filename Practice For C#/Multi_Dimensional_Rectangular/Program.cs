using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Dimensional_Rectangular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] my_array = new int[2, 3]
            {
                {1,2,3 },
                {4,5,6 },
            };

            for (int i = 0; i < my_array.GetLength(0); i++)
            {
                for (int j = 0; j < my_array.GetLength(1); j++)
                {
                    Console.Write(my_array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
