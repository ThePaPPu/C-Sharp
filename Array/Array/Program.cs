internal class Program
{
    private static void Main(string[] args)
    {
        string[] Name = new string[10];
        int[] Id = new int[10];
        int i;

        for (i = 0; i < 3; i++)
        {
            Console.WriteLine("Name " + i + ":");

            Name[i] = Console.ReadLine();

            Console.WriteLine("Id " + i + ":");
            Id[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < 3; i++)
        {
            Console.WriteLine(Name[i]);
            Console.WriteLine(Id[i]);
        }

        Console.WriteLine("Enter Replace: ");
        string replace = Console.ReadLine();

        Name[1] = replace;

        Console.WriteLine(Name[1]);

        for (i = 0; i < 3; i++)
        {
            Console.WriteLine(Name[i]);
        }


    }
}