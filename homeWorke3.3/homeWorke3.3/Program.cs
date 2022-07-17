using System;

namespace homeWorke3._3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Введите число: ");
            int n = int.Parse(Console.ReadLine());

            bool primeNumber = true;
            int i = 2;

            while (i <= n / 2)
            {
                if (n % i == 0)
                {
                    primeNumber = false;
                    break;
                }
                i++;
            }
            if (primeNumber)
            {
                Console.WriteLine("Число является простым");
            }
            else
            {
                Console.WriteLine("Число не является простым");
            }
            Console.ReadKey();

        }
    }
}





