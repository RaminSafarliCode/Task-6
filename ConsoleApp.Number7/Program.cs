using System;
using ClassLibrary.Helpers;
namespace ConsoleApp.Number7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7) Verilmish metnde {a} simvolu {b} simvolundan qabaq ve oda {c} simvolundan qabaq gelirmi?

            string text = Monitor.ReadString("Input a text: ");

            string newText = text.ToLower();

            int indexA = newText.IndexOf('a');
            int indexB = newText.IndexOf('b');
            int indexC = newText.IndexOf('c');

            if (indexA < indexB && indexB < indexC)
            {
                Console.WriteLine("Ard arda gelir");
            }
            else
            {
                Console.WriteLine("Ard arda gelmir");
            }
        }
    }
}
