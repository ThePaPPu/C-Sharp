using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Department : ");
            string department = Console.ReadLine();

            Console.Write("Enter Your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your CGPA : ");
            double cgpa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nName : " + name);
            Console.WriteLine("Department : " + department);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("CGPA : " + cgpa);

            Console.ReadLine();
        }
    }
}
