using System;

namespace IkilikTabanıOnlukTabanaCevirme
{
    class Program
    {
        static void Main(string[] args)
        {
            double onlukSayi = 0;
            bool durum = true;
            Console.WriteLine("İkilik tabandaki sayıyı girniz :");
            string ikilikSayi = Console.ReadLine();
            for (int i = 0; i < ikilikSayi.Length; i++)
            {
                if(Convert.ToDouble(ikilikSayi.Substring(i,1))<2)
                {
                    onlukSayi += Convert.ToDouble(ikilikSayi.Substring(i, 1)) * Math.Pow(2, ikilikSayi.Length - i - 1);

                }
                else
                {
                    Console.WriteLine("İkilik sayı tabanı 1 ve 0 lardan oluşmaktadır.");
                    
                }
            }
            if(durum==true)
            {
                Console.Write(ikilikSayi + "sayının onluk sayı tabanı karşılığı :" + onlukSayi);
            }
            Console.ReadKey();
        }
    }
}
