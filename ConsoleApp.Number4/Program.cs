using System;
using ClassLibrary.Helpers;

namespace ConsoleApp.Number4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdi yoxsa cut ?

            Console.Title = "Symbol counter";

            string text = Monitor.ReadString("Input a text: "); 

            int index = text.ToLower().IndexOf('a');

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Inputed text: {text}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("********** Result **********");

            if ((index + 1) % 2 != 0)
            {
                Console.ForegroundColor= ConsoleColor.Cyan;
                Console.WriteLine($"The first place of first 'a' symbol is odd number!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"The first place of first 'a' symbol is even number!");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ReadKey();

        }
    }
}
