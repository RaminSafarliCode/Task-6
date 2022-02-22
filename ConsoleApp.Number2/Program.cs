using System;
using ClassLibrary.Helpers;

namespace ConsoleApp.Number2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu ?

            string text = Monitor.ReadString("Input a text: ");
            text = text.ToLower();

            int countA = 0;
            int countB = 0;

            char symbol;

            for (int i = 0; i < text.Length; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    countA++;
                    symbol = text[i];

                    if (symbol == 'a')
                    {
                        countB++;
                    }
                }
            }

            if (countA == countB)
            {
                Console.WriteLine("The symbols stand on odd places are {a}");
            }
            else
            {
                Console.WriteLine("The symbols stand on odd places are not {a}");
            }
        }
    }
}
