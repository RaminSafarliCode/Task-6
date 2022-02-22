using System;
using ClassLibrary.Helpers;
namespace ConsoleApp.Number9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9) Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.?

            string text = Monitor.ReadString("Input a text: ");
            string newText = text.ToLower();

            string textFirst = newText.Substring(0, 3);
            string textLast = newText.Substring(newText.Length - 3, 3);

            string reversedSubstring = "";

            for (int i = textLast.Length - 1; i > -1; i--)
            {
                reversedSubstring += textLast[i];
            }

            if (textFirst == reversedSubstring)
            {
                Monitor.Print("The first 3-symbols and reverse of last 3-symbols are the same!");
            }
            else
            {
                Monitor.PrintError("The first 3-symbols and last 3-symbols are not the same!");
            }
        }
    }
}
