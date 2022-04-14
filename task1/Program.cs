using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1) Bir string arrayinin icersinde uzunlugu 5 den boyuk olan sozleri ekrana cixardan bir alqoritm yazin.



            string[] words = { "Nazrin", "Firuza", "Gul", "Leyla" };
            foreach (string word in words)
            {
                int wl = word.Length;
                if (wl > 5)
                {
                    Console.WriteLine(word);
                }

            }


        }
    }
}

