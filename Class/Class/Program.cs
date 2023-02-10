using System;

namespace classDemo
{
    public class Person
    {
        public string? firstName = "None";
        public string? lastName = "None";

        public void UserInput()
        {
            string firName, lasName;

            Console.WriteLine("First Name: ");
            firName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            lasName = Console.ReadLine();

            SetInfo(firName, lasName);
        }

        public void SetInfo(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }

        public void UpdateInfo()
        {
            UserInput();
            PrintMethod();
        }

        public void PrintMethod()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            int choise;

            while (true)
            {
                Console.WriteLine("\n1 = UserInput, 2 = PrintMethod, 3 = UpdateInfo");
                Console.Write("Select Option first: ");
                choise = Convert.ToInt32(Console.ReadLine());


                if (choise == 1)
                {
                    Console.WriteLine("Congratulations, you have choose UserInput Option!");
                    person.UserInput();
                }

                else if (choise == 2)
                {
                    Console.WriteLine("Congratulations, you have choose PrintMethod Option!");
                    person.PrintMethod();
                }

                else if (choise == 3)
                {
                    Console.WriteLine("Congratulations, you have choose UpdateInfo Option!");
                    person.UpdateInfo();
                }

                else
                {
                    Console.WriteLine("Something is wrong...Try Again!!");
                }
            }
        }
    }
}

