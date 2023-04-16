using System;

namespace Homework_number_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol;
            string userName;
            int numberLettersInName;

            Console.Write("Укажите символ, которым будет обведено ваше имя: ");
            symbol = Convert.ToChar(Console.ReadLine());

            Console.Write("Укажите ваше имя: ");
            userName = Console.ReadLine();

            numberLettersInName = userName.Length;
            numberLettersInName++;

            for (int i = 0; i <= numberLettersInName; i++)
            {
                Console.Write(symbol);
            }

            Console.Write($"\n{symbol}{userName}{symbol}\n");

            for (int i = 0; i <= numberLettersInName; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}
