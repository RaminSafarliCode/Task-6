using System;
using ClassLibrary.Helpers;

namespace ConsoleApp.Number5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) Verilmish metnde sol terefden saydiqda { a},{ b},{ c} simollarindan hansi birinci gelir?

            Console.Title = "Symbol counter";

            string text = Monitor.ReadString("Input a text: ");

            char[] symbols = { 'a', 'b', 'c' };
            int index = text.ToLower().IndexOfAny(symbols);

            Console.WriteLine($"The first symbols among given symbols: {text[index]}");

            Console.ReadKey();
        }
    }
}
