using System;

namespace homeWorke3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите число: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 != 0)
            {
                Console.WriteLine("Данное число не четное");
            }
            else
            {
                Console.WriteLine("Данное число четное");
            }

            Console.ReadKey();
        }
    }
}
