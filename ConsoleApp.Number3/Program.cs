using System;
using ClassLibrary.Helpers;


namespace ConsoleApp.Number3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi { b}-ye beraberdir.


            Console.Title = "Symbol counter";

            string text = Monitor.ReadString("Input a text: ");

            string lowerText = text.ToLower();

            int counter = 1, counterB = 0;

            for (int i = 0; i < lowerText.Length; i++)
            {
                if (counter % 2 != 0 && lowerText[i] == 'b')
                {
                    counterB++;
                }
                counter++;
            }
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Inputed text: {text}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("****************************");

            Console.WriteLine($"The number of 'b' symbols in odd places: {counterB}");
        }
    }
}
