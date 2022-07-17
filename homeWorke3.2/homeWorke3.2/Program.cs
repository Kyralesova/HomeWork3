using System;

namespace homeWorke3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Приветствую, Вас!!! Введите число карт: ");
            int cards = int.Parse(Console.ReadLine());
            int sumCards = 0;

            for (int i = 1; i <= cards; i++)
            {
                Console.Write("Введите номинал карты: ");
                string nominal = Console.ReadLine();

                int value = 0;

                switch (nominal)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        value = 10;
                        break;
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                        value = int.Parse(nominal);
                        break;
                    default:
                        Console.WriteLine("Допустимы номиналы 2-10, J, Q, K, T");
                        i--;
                        break;
                }
                sumCards += value;
            }
            Console.WriteLine("Сумма карт руки: " + sumCards);
            Console.ReadKey();
        }




    }

}
