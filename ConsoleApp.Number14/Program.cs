using System;
using ClassLibrary.Helpers;

namespace ConsoleApp.Number14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14) Verilmish metinde butun tek yerde dayanan simvollari ondan sonra gelen simvolun BOYUK formasi ile evez et.

            string text = Monitor.ReadString("Input a text: ");

            string newText = "";
            string textCh = "";
            string textCh2 = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0 && i != text.Length - 1)
                {
                    textCh2 = Convert.ToString(text[i + 1]).ToUpper();
                    textCh = Convert.ToString(text[i]);
                    textCh = textCh.Replace(textCh, textCh2);

                    newText += textCh;
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
