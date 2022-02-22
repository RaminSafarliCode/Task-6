using System;
using ClassLibrary.Helpers;
namespace ConsoleApp.Number12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12) Verilmish metinde en ilk ve en son { a}
            //      simvolundan bashqa yerde qalan butun { a}
            //      simvollarini yox et.

            string text = Monitor.ReadString("Input a text: ");
            text = text.ToLower();

            string newText = "";

            int indexFirst = text.IndexOf('a');
            int indexLast = text.LastIndexOf('a');  

            for (int i = 0; i < text.Length; i++)
            {
                if (i != indexFirst && i != indexLast)
                {
                    if (text[i] != 'a')
                    {
                        newText += text[i];
                    }
                }
                else
                {
                    newText += text[i];
                }
            }

            Console.WriteLine(newText);


        }
    }
}
