using System;
using System.Linq;
using System.Text.RegularExpressions;
using ClassLibrary.Helpers;

namespace ConsoleApp.Number10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10) Verilmish metinde butun reqemleri legv et.

            string text = Monitor.ReadString("Input a text: ");

            text = Regex.Replace(text, @"[\d-]", string.Empty);
                                                                                 // Regular Expression
            Console.WriteLine(text);

            /*  second version
            int[] numCharCodes = { 48, 49, 50, 51, 52, 53, 54, 55, 56, 57 };
            int[] numCharCodes = Enumerable.Range(48, 10).ToArray();

            string newText = "";

            for (int i = 0; i < text.Length; i++)
            {
                byte charCode = (byte)text[i];

                if (Array.IndexOf(numCharCodes, charCode) == -1)
                {
                    newText = newText + text[i];
                }
            }
            Console.WriteLine(text);
            Console.WriteLine(newText);
            */
        }
    }
}
