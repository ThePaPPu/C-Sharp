internal class Program
{
    private static void Main(string[] args)
    {
        string firstName;
        string lastName;
        string fullName;

        Console.WriteLine("First Name: ");
        firstName = Console.ReadLine();
        Console.WriteLine("First Name: " + firstName);

        Console.WriteLine("Last Name: ");
        lastName = Console.ReadLine();
        Console.WriteLine("Last Name: " + lastName);

        fullName = string.Concat(firstName, lastName);
        Console.WriteLine("Full Name: " + fullName);

        int index = fullName.IndexOf('p');
        Console.WriteLine("Index of P: " + index);

        Console.WriteLine("Char of 3rd position of Full Name: " + fullName[3]);
        Console.WriteLine("Length of First Name: " + firstName.Length);

        Console.WriteLine("Upper: " + firstName.ToUpper());

        firstName = string.Empty;
        Console.WriteLine("Empty : " + firstName);
    }
}