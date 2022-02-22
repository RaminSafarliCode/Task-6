using System;
using System.Text;
using ClassLibrary.Helpers;
namespace ConsoleApp.Number11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11) Verilmish metinde butun { a} simvollarinin qabagina { b}  simvolunu ve eyni zamandan butun { b} simvollarinin qabagina { a}
            //simvolunu yaz.

            string text = Monitor.ReadString("Input a text: ");

            string textLower = text.ToLower();
            string newText = "";

            for (int i = 0; i < text.Length; i++)
            {
                newText += textLower[i];
                if (textLower[i] == 'a')
                {
                    newText += 'b';
                }
                else if (textLower[i] == 'b')
                {
                    newText += 'a';
                }
            }
            
            Console.WriteLine($"The new text: {newText}");



        }
    }
}
