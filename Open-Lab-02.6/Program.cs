using System;

namespace Open_Lab_02._6
{
    class Program
    {
        public static bool Divisible(int num)
        {
            return (num % 100 == 0);
        }
        static void Main(string[] args)
        {
            bool divisible;
            int num;

            Console.WriteLine("Zadaj si číslo:");
            num = int.Parse(Console.ReadLine());

            divisible = Divisible(num);
            Console.WriteLine(divisible);
        }
    }
}
