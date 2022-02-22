using System;
using ClassLibrary.Helpers;
namespace ConsoleApp.Number8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8) Verilmish metnde ilk qabagima cixan { a} simvolundan sonra gelen simvolu 10 defe dalbadal cap et.

            string text = Monitor.ReadString("Input a text: ");

            int index = text.ToLower().IndexOf('a');

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(text[index + 1]);
            }
        }
    }
}
