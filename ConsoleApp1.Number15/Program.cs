using System;
using ClassLibrary.Helpers;

namespace ConsoleApp1.Number15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //15)*Verilmish metinde ilk ve son simvol eynidirse,
            //    ve metn daxilinde yanashi gelen { a}
            //    simvolu varsa,
            //    ve metn daxilinde { b}
            //    simvolu yoxdursa
            //    o zaman bu metnde butun { c}
            //    simvollari yox et ve
            //    neticede alinan metn zerkalni olub olmadigini yoxla.
                                            //&& (text[i] == 'a' && i != text.Length - 1 && text[i + 1] == 'a')
            string text = Monitor.ReadString("Input a text: ");

            string reversedText = "";

            for (int i = 0; i < text.Length; i++)
            {
                bool success = (text[0] == text[text.Length - 1]) && text[i] != 'b';

                if (success)
                {
                    text = text.Replace("c", String.Empty);
                }
                else
                {
                    Console.WriteLine("One or more of the conditions are not true");
                    break;
                }
                
            }
            Console.WriteLine(text);

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }

            if (text == reversedText)
            {
                Console.WriteLine("The new text is a mirror string!");
            }
            else
            {
                Console.WriteLine("The new text is not a mirror string!");
            }
        }
    }
}
