using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());
            string result = String.Empty;

            if (marks <= 0 || marks > 100)
            {
                result = "You enter invalid marks!!";
            }

            else if (marks >= 40)
            {
                result = "Passed!";
            }

            else
            {
                result = "Failed!";
            }

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
