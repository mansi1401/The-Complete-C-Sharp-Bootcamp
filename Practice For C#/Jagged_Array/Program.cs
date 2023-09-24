using System;

namespace Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] my_array = new int[2][];

            my_array[0] = new[] { 1, 2, 3, 4, 5 };
            my_array[1] = new[] { 6, 7, 8, 9 };

            Console.WriteLine("Using For Loop");
            for (int i = 0; i < my_array.GetLongLength(0); i++)
            {
                for(int j = 0; j < my_array[i].Length; j++)
                {
                    Console.Write(my_array[i][j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nUsing foreach Loop");
            foreach (int[] item in my_array)
            {
                foreach (int i in item)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
