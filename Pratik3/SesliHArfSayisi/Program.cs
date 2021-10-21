using System;

namespace SesliHArfSayisi
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle;
            char[] sesli = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
            int adet = 0;
            Console.Write("Cümle Giriniz : ");
            cumle = Console.ReadLine();
            for (int i = 0; i < cumle.Length; i++)
            {
                for (int k = 0; k < sesli.Length; k++)
                {
                    if (cumle[i] == sesli[k])
                    {
                        adet++;
                    }
                }
            }
            Console.WriteLine("sesli harf sayısı : {0}", adet);
            Console.ReadKey();
        }
    }
}
