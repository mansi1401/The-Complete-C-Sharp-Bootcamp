using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Or_Functions
{
    class Abc
    {
        //Non Static Method or Non-Parameterized Method
        public void Show()
        {
            Console.WriteLine("This is Show Method");
        }

        //Static Method
        public static void Hide()
        {
            Console.WriteLine("This is Hide Method");
        }

        //Parameterized or Static Method
        public static void AddTwoNumber(int num1, int num2)
        {
            int resutl = num1 + num2;
            Console.WriteLine("Sum of Two Number = " + resutl);
        }

        public static int SubtractionTwoNumber(int num1, int num2)
        {
            int resutl = num1 - num2;
            //Console.WriteLine("Subtraction of Two Number = " + resutl);
            return resutl;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Create Object for Non Static Method
            Abc obj = new Abc();
            obj.Show();

            //Call direct Using Class name for Static Method
            Abc.Hide();

            //Parameterized Method Call direct Using Class name for Static Method
            Console.WriteLine("Enter First Number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int b = int.Parse(Console.ReadLine());

            Abc.AddTwoNumber(a, b);
            Console.WriteLine(Abc.SubtractionTwoNumber(a, b));

            Console.ReadLine();
        }
    }
}
