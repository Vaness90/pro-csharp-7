using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp_chapter3
{
    internal class Program
    {
        static int Main(string[] args)
        {
            // Вывести пользователю простое сообщение
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World");
            Console.WriteLine();

            // Вывести на экран аргументы при запуске программы
            // for (int i = 0; i < args.Length; i++)
            //     Console.WriteLine("Arg: {0}", args[i]);

            // вывести на экран аргументы при запуске программы при помощи foreach
            // foreach(string arg in args)
            //     Console.WriteLine("Arg: {0}", arg);

            // Получение аргументов запуска программы с помощью класса Envirinment
            // String[] theArgs = Environment.GetCommandLineArgs();
            // foreach(string arg in theArgs)
            //     Console.WriteLine("Arg: {0}", arg);

            // Вспомогательный метод внутри класса Program
            ShowEnvironmentDetails();

            // Ожидать нажатия клавиши <Enter>, прежде чем завершить работу.
            Console.ReadLine();

            // Возвратить код ошибки
            return -1;
        }

        static void ShowEnvironmentDetails()
        {
            // Вывести информацию у дисковых устройствах
            // данной машины и другие интересные делали
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("StackTrace: {0}", Environment.StackTrace);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".Net version: {0}", Environment.Version);
        }

    }
}
