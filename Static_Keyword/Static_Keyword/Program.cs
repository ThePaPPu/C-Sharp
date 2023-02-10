using Static_Keyword.Static_Class;

class Program
{
    public static void Main(string[] args)
    {
        int sum = Claculator.Sum(4, 4);
        Console.WriteLine(sum);

        int mul = Claculator.Mul(4, 4);
        Console.WriteLine(mul);
    }
}