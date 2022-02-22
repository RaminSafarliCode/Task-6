using System;
using ClassLibrary.Helpers;

namespace ConsoleApp.Number13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13) Verilmish metnde butun simvollari ardicil sekilde
            // biri balaca, biri boyuk formada cap et.

            string text = Monitor.ReadString("Input a text: ");

            string newText = "";
            string textCh = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    textCh = Convert.ToString(text[i]).ToLower();
                    newText += textCh; 
                }
                else
                {
                    textCh = Convert.ToString(text[i]).ToUpper();
                    newText += textCh;
                }
            }

            Console.WriteLine(newText);
        }
    }
}
