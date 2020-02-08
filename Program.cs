using System;

namespace OddEvenNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a = Console.Read();
            int b = a % 2;
            if (b == 0)
            {
                Console.WriteLine("Число четное!");
            }
            else
            {
                Console.WriteLine("Число нечетное!");
            }
            

        }
    }
}
