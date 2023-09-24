using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializing_Or_Creating_Array_With_User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Number of item you want to store in Array");
            int nums = int.Parse(Console.ReadLine());

            int[] numbers = new int[nums];

            for (int i = 0; i < nums; i++)
            {
                Console.WriteLine("\nEnter Your Data in Index No " + i);
                int array_input = int.Parse(Console.ReadLine());
                numbers[i] = array_input;
            }

            Console.WriteLine("----------------Your Data\n");
            foreach (int i in numbers)
            {
                Console.Write(i);
            }
            Console.ReadLine();
        }
    }
}
