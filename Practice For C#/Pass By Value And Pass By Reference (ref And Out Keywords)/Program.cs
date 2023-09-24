using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_By_Value_And_Pass_By_Reference__ref_And_Out_Keywords_
{
    internal class Program
    {
        public static void PassByValue(int num1)
        {
            num1 = num1 + 10;
            Console.WriteLine("Value is " + num1);
        }
        static void Main(string[] args)
        {
            int value = 5;
            Program.PassByValue(value);

            Console.WriteLine(value);

            Console.ReadLine();
        }
    }
}
