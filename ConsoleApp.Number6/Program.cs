using System;
using ClassLibrary.Helpers;

namespace ConsoleApp.Number6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6) Verilmish metnde { a} simvolunun sol terefden ve sag terefden indexleri eydidirmi?

            string text = Monitor.ReadString("Input a text: ");
            text = text.ToLower();

            string newText = "";
            int counter = 0;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                newText += text[i];
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' && newText[i] == 'a')
                {
                    counter++;
                }
            }

            if (counter != 0)
            {
                Console.WriteLine("Indexes are the same!");
            }
            else
            {
                Console.WriteLine("Indexes are not the same!");
            }




            // ***************** Second version *****************
            /*
            int count = 0, countReverse = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    count++;
                }
            }

            for (int j = text.Length - 1; j >= 0; j--)
            {
                if (text[j] == 'a')
                {
                    countReverse++;
                }
            }

            if (count == countReverse)
            {
                Console.WriteLine("Indexes are the same!");
            }
            else
            {
                Console.WriteLine("Indexes are not the same!");
            } 
            */
        }
    }
}
