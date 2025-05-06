// See https://aka.ms/new-console-template for more information


using System;

namespace YazilimciOl
{

    class Program
    {

        static void Main(String[] args)
        {

            string[] nedenler = {

                "Daha konforlu bir yaşam için öğreniyorum.",
                "İstediğim yerde çalışabilme özgürlüğü.",
                "boş vakitlerimi verimli bir şey ile geçirebilmek için."
            };

            Console.WriteLine("Neden yazılımcı olmalıyım?");
            Console.WriteLine("--------------------------");

            foreach (string neden in nedenler)
            {
                Console.WriteLine("-" + neden);
            }
            Console.ReadLine();

        }
    }
}