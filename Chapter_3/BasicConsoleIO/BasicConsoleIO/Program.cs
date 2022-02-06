using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");
            GetUserData();
            FormatNumericalData();
            Console.ReadLine();
        }
        private static void GetUserData()
        {
            // Получить данные об имени и возрасте
            Console.Write("Please, enter your name: "); // Предложить ввести имя
            string userName = Console.ReadLine();

            Console.Write("Please, enter your age: "); // Предложить ввести возраст
            string userAge = Console.ReadLine();

            // Поменять цвет переднего плана 
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Вывести полученную информацию
            Console.WriteLine("Hello, {0}, You are {1} years old", userName, userAge);

            // Восстановить цвет консоли
            Console.ForegroundColor=prevColor;
        }

        static void FormatNumericalData()
        {
            //Выводим число 9999 в разных форматах
            Console.WriteLine("The value 99999 in variors formats:");
            Console.WriteLine("c format: {0:c}", 9999);
            Console.WriteLine("d9 format: {0:d9}", 9999);
            Console.WriteLine("f3 format: {0:f3}", 9999);
            Console.WriteLine("n format: {0:n}", 9999);
            Console.WriteLine("e format: {0:e}", 9999);
            Console.WriteLine("E format: {0:E}", 9999);
            Console.WriteLine("x format: {0:x}", 9999);
            Console.WriteLine("X format: {0:X}", 9999);
        }

    }
}
