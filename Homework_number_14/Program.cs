using System;

namespace Homework_number_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol;
            string userName;
            string middleLine = "";
            string horizontalLine = "";

            Console.Write("Укажите символ, которым будет обведено ваше имя: ");
            symbol = Convert.ToChar(Console.ReadLine());

            Console.Write("Укажите ваше имя: ");
            userName = Console.ReadLine();

            middleLine = symbol + userName + symbol;

            for (int i = 0; i < middleLine.Length; i++)
            {
                horizontalLine += symbol;
            }

            Console.WriteLine($"{horizontalLine}\n{middleLine}\n{horizontalLine}");
        }
    }
}
