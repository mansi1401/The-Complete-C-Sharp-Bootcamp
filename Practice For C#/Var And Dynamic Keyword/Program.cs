using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_And_Dynamic_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Var Keyword");
            var b = 5;
            Console.WriteLine("\nvalue of b is " + b);
            Console.WriteLine("Type of b is " + b.GetType());

            var a = "Maan";
            Console.WriteLine("\nvalue of a is " + a);
            Console.WriteLine("Type of a is " + a.GetType());

            //var a;

            Console.WriteLine("\nDynamic Keyword");

            dynamic abc = 50;
            Console.WriteLine("\nvalue of abc is " + abc);
            Console.WriteLine("Type of abc is " + abc.GetType());

            dynamic xyz;
            xyz = "Maan";
            Console.WriteLine("\nvalue of xyz is " + xyz);
            Console.WriteLine("Type of xyz is " + xyz.GetType());

            dynamic pqr = 10;
            Console.WriteLine("\nvalue of pqr is " + pqr);
            pqr = "Ash";
            Console.WriteLine("\nvalue of pqr is " + pqr);
            Console.WriteLine("Type of pqr is " + pqr.GetType());

            Console.ReadLine();
        }
    }
}
