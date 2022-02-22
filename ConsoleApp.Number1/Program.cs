using System;
using ClassLibrary.Helpers;

namespace ConsoleApp.Number1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur ?

            Console.Title = "Symbol counter";

            string text = Monitor.ReadString("Input a text: ");

            int countA = 0, countB = 0;
            double result = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    countA++;
                }
                else if (text[i] == 'b')
                {
                    countB++;
                }
            }
            
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Inputed text: {text}");
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine($"The number of 'a' symbols: {countA}");
            Console.WriteLine($"The number of 'b' symbols: {countB}");

            Console.WriteLine("************** Division ***************");

            bool success = countB != 0;
            switch (success)
            {
                case true:
                    {
                        result = countA * 1.0 / countB;
                        Console.WriteLine($"The number of 'a' is {result} times larger than the number of 'b'");
                        break;
                    }
                default:
                    Monitor.PrintError("There are not any 'b' symbol. So, the program cannot operate division!");
                    break;
            }
            
            Console.ReadKey();

        }
    }
}
