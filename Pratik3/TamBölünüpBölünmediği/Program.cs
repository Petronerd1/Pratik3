using System;

namespace TamBölünüpBölünmediği
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Sayıyı Giriniz = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz = ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a % b == 0)
                {
                    Console.Write(a + " Sayısı " + b + " Sayısına Tam Bölünüyor");
                }
                else
                {
                    Console.Write("Bu Sayılar Birbirine Tam Bölünmez");
                }
            }
            else
            {
                if (b % a == 0)
                {
                    Console.Write(b + " Sayısı " + a + " Sayısına Tam Bölünüyor.");
                }
                else
                {
                    Console.Write("Bu Sayılar Birbirine Tam Bölünmez");
                }
            }
            Console.ReadKey();
        }
    }
}
