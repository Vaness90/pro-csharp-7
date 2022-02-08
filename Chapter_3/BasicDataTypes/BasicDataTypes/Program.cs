using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LocalVarDeclaration");
            Console.WriteLine("1. DefaultDeaclarations");
            Console.WriteLine("2. NewingDataTypes");
            Console.WriteLine("3. NewingDataTypes");
            Console.WriteLine("4. ObjectFunctionality");
            Console.WriteLine("5. DataTypeFunctionality");
            Console.WriteLine("6. CharFunctionality");
            Console.WriteLine("7. Datatypeparsing");

            int x = Int32.Parse(Console.ReadLine());

            switch(x)
            {
                case 1:
                    LocalVarDeclaration();
                    break;
                case 2:
                    DefaultDeaclarations();
                    break;
                case 3:
                    NewingDataTypes();
                    break;
                case 4:
                    ObjectFunctionality();
                    break;
                case 5:
                    DataTypeFunctionality();
                    break;
                case 6:
                    CharFunctionality();
                    break;
                case 7:
                    ParseFromString();
                    break;
                default:
                    break;
            }

        }

        static void LocalVarDeclaration()
        {
            Console.WriteLine("=> Data Declarations:");
            //Объявление локальных переменных

            int myInt = 0;
            string myString;
            myString = "This is my character data";

            //Объявление нескольких локальных переменных в одной строке

            bool b1 = true, b2 = false, b3 = b1;

            //Использование типа данных System.Boolean для объявления булевой переменной
            System.Boolean b4 = false;
            Console.WriteLine("Your data: {0},{1},{2},{3},{4},{5}", myInt, myString, b1,b2,b3,b4);
        }

        static void DefaultDeaclarations()
        {
            Console.WriteLine("=> Default Declarations:");
            // установка значений с помощью default
            int myInt = default;
            Console.WriteLine(myInt);
        }

        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables:");
            // установка значений с помощью new
            bool b = new bool();
            int i = new int();
            double d = new double();
            DateTime dt = new DateTime();
            Console.WriteLine("{0},{1},{2},{3}", b,i,d,dt);
        }

        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality");
            Console.WriteLine("12.GetHashCode(): {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(12): {0}", 12.Equals(12));
            Console.WriteLine("12.ToString(): {0}", 12.ToString());
            Console.WriteLine("12.GetType(): {0}", 12.GetType());


        }

        static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type Functionality:");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);

            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);

            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);

            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);


            Console.WriteLine();

        }

        static void CharFunctionality()
        {
            Console.WriteLine("=> char Functionality:");
            char myChar = 'a';
            char myIntChar = '1';

            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            
            Console.WriteLine("char.IsDigit('1'): {0}", char.IsDigit(myIntChar));
            Console.WriteLine("char.IsLetter('1'): {0}", char.IsLetter(myIntChar));

            Console.WriteLine("char.IsWhiteSpace ('Hello There', 5): {0}", char.IsWhiteSpace("Hello There",5));
            Console.WriteLine("char.IsWhiteSpace ('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation ('?'): {0}", char.IsPunctuation('?'));

            Console.WriteLine();

        }

        static void ParseFromString()
        {
            Console.WriteLine("=> Data type parsing:");

            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);

            double d = double.Parse("99,884");
            Console.WriteLine("Value of d: {0}", d);

            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);

            char c = Char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);
            Console.WriteLine();
        }


    }
}
