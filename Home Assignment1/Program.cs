using System;
namespace Add
{
    public class Program
    {
        public static void Main()
        {
            int a, b;
            int sum;
            Console.Write("Birinci reqemi daxil edin: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci reqemi daxil edin: ");
            b = Convert.ToInt32(Console.ReadLine());
            sum = (a + b);
            Console.WriteLine("Cem beraberdir: " + sum);
        }
    }
}
