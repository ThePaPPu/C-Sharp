using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Pappu";
            string department = "CSE";
            int age = 24;
            double cgpa = 3.38;
            bool is_bd = true;

            Console.WriteLine("Name : " + name);
            Console.WriteLine("Department : " + department);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("CGPA : " + cgpa);
            Console.WriteLine("Is Bangladeshi : " + is_bd);
            Console.ReadLine();

        }
    }
}
