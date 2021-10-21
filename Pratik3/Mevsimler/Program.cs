using System;

namespace Mevsimler
{
    class Program
    {
        static void Main(string[] args)
        {
            string mevsim;
            Console.Write("1-4 Arasında Bir rakam giriniz: ");
            mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "1":
                    Console.Write("İlkbahar");
                    break;
                case "2":
                    Console.Write("Yaz");
                    break;
                case "3":
                    Console.Write("Sonbahar");
                    break;
                case "4":
                    Console.Write("Kış");
                    break;
                default:
                    Console.Write("Lütfen 1-4 arasında bir sayı giriniz.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
