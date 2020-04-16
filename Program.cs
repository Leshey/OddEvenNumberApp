using System;

namespace OddEvenNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInt = false;
            int number;
            int rem;

            Console.WriteLine("Введите число:");
            while (isInt == false)                    //Комментарий
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    isInt = true;
                    rem = number % 2;
                    if (rem == 0)
                    {
                        Console.WriteLine("Число четное!");
                    }
                    else
                    {
                        Console.WriteLine("Число нечетное!");
                    }
                }
                else 
                {
                    Console.WriteLine("Необходимо ввести число!");
                }
            }
        }
    }
}
