using System;
namespace Add
{
    public class Program
    {
        public static void Main()
        {
            int a, b;
            int sum;
            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            sum = (a + b);
            Console.WriteLine("Sum is: " + sum);
        }
    }
}
