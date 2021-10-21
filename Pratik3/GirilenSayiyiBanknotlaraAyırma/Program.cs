using System;

namespace GirilenSayiyiBanknotlaraAyırma
{
    class Program
    {
        static void Main(string[] args)
        {
            int MoneyAmo = 0;
            Console.Write("Çekilecek Para Tutarını Yazınız: ");
            MoneyAmo = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------- ");
            int a200 = 0, a100 = 0, a50 = 0, a20 = 0, a10 = 0, a5 = 0, a1 = 0;         
            if (MoneyAmo >= 200)
            {
                a200 = MoneyAmo / 200;
                MoneyAmo = MoneyAmo % 200;
            }           
            if (MoneyAmo >= 100)
            {
                a100 = MoneyAmo / 100;
                MoneyAmo = MoneyAmo % 100;
            }        
            if (MoneyAmo >= 50)
            {
                a50 = MoneyAmo / 50;
                MoneyAmo = MoneyAmo % 50;
            }         
            if (MoneyAmo >= 20)
            {
                a20 = MoneyAmo / 20;
                MoneyAmo = MoneyAmo % 20;
            }         
            if (MoneyAmo >= 10)
            {
                a10 = MoneyAmo / 10;
                MoneyAmo = MoneyAmo % 10;
            }          
            if (MoneyAmo >= 5)
            {
                a5 = MoneyAmo / 5;
                MoneyAmo = MoneyAmo % 5;
            }
            if (MoneyAmo >= 1)
            {
                a1 = MoneyAmo / 1;
                MoneyAmo = MoneyAmo % 1;
            }
            Console.WriteLine("200 Banknote Unit   : " + a200);
            Console.WriteLine("100 Banknote Unit   : " + a100);
            Console.WriteLine("50 Banknote Unit    : " + a50);
            Console.WriteLine("20 Banknote Unit    : " + a20);
            Console.WriteLine("10 Banknote Unit    : " + a10);
            Console.WriteLine("5 Banknote Unit     : " + a5);
            Console.WriteLine("1 Banknote  Unit  : " + a1);
            Console.ReadKey();
        }
    }
}
