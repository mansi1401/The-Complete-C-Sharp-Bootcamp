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

        public static void PassByReference(ref int num2)
        {
            num2 = num2 + 10;
            Console.WriteLine("Value is " + num2);
        }

        public static void PassByOut(out int num3)
        {
            num3 = 10;
            Console.WriteLine("Value is " + num3);
        }

        static void Main(string[] args)
        {
            //Pass By Value
            Console.WriteLine("Pass By Value");
            int value = 5;
            Program.PassByValue(value);
            Console.WriteLine(value);

            //Pass By Reference
            Console.WriteLine("Pass By Reference");
            Program.PassByReference(ref value);
            Console.WriteLine(value);

            //PassByOut
            Console.WriteLine("Pass By Out");
            int data;
            Program.PassByOut(out data);
            Console.WriteLine(data);

            Console.ReadLine();
        }
    }
}
