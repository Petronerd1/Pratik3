using System;

namespace GEriyeDoğruSayı
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 20; a >= 1; a-- )
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();             
            int sayi = 20;
            while (sayi >= 1)
            {
                Console.WriteLine(sayi);
                sayi = sayi-1;
            }
            Console.ReadKey();

        }
    }
}
