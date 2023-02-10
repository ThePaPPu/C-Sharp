internal class Program
{
    public class EvenOddCalculation
    {
        public void EvenOddCalculationMethod(int number)
        {
            if (number%2 == 0) 
            {
                Console.WriteLine(number + " is Even number.");
            }
            else if(number%2 == 1)
            {
                Console.WriteLine(number + " is Odd number.");
            }
            else
            {
                Console.WriteLine(number + "is wrong!!");
            }
        }
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter number for check Even or Odd: ");
        int n = Convert.ToInt32(Console.ReadLine());
        EvenOddCalculation method = new EvenOddCalculation();
        method.EvenOddCalculationMethod(n);

        //end
    }
}