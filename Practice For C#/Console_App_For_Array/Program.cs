using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_For_Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] my_array = new string[] { "Ash", "Suyash", "Maan" };
            Console.WriteLine("Array of String");
            foreach (var data in my_array)
            {
                Console.WriteLine(data);
            }

            int[] numbers = { 1, 2, 3, 4 };
            Console.WriteLine("\nArray of Number");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("\nArray of Floats");
            float[] floats = new float[2];
            floats[0] = 1;
            floats[1] = 2;
            for (int i = 0;i < floats.Length; i++)
            {
                Console.WriteLine(floats[i]);
            }

            Console.ReadLine();
        }
    }
}
