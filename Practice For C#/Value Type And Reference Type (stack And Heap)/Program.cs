using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Type_And_Reference_Type__stack_And_Heap_
{
    public struct Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //For Employee
            // First Employee
            Employee employee = new Employee();
            employee.Age = 20;
            employee.Name = "Maan";

            // Second Employee
            Employee employee2 = employee;

            // Third Employee
            Employee employee3 = employee;

            employee.Age = 23;

            Console.WriteLine("Value Type\n");
            Console.WriteLine("First Employee " + employee.Age);
            Console.WriteLine("Second Employee " + employee2.Age);
            Console.WriteLine("Third Employee " + employee3.Age);

            //For Student
            // First Student
            Student student = new Student();
            student.Name = "Maan";
            student.Age = 19;

            // Second Student
            Student student1 = student;

            // Third Student
            Student student2 = student1;

            student.Age = 23;

            Console.WriteLine("\nReference Type\n");
            Console.WriteLine("First Student " + student.Age);
            Console.WriteLine("Second Student " + student1.Age);
            Console.WriteLine("Third Student " + student2.Age);

            Console.ReadLine();


        }
    }
}
