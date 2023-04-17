using System;

namespace Homework_number_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isLineCorrect = false;
            char symbol;
            string userName;
            string middLeLine = "";
            string horizontalLine = "";
           
            Console.Write("Укажите символ, которым будет обведено ваше имя: ");
            symbol = Convert.ToChar(Console.ReadLine());

            Console.Write("Укажите ваше имя: ");
            userName = Console.ReadLine();


            middLeLine = symbol + userName + symbol;

            for (int i = 0; i < middLeLine.Length; i++)
            {
                horizontalLine += symbol;
            }

            Console.WriteLine($"{horizontalLine}\n{middLeLine}\n{horizontalLine}");

        }
    }
}
