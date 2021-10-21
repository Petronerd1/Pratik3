using System;

namespace CelsiustoFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 33.8;
            Console.WriteLine("celsius'u gir:");            
            double celcius = Convert.ToDouble(Console.ReadLine());
            if (celcius == 1)
            {
                Console.WriteLine(fahrenheit);
            }
            else
            {
                double sonuc = (1.8 * celcius - 1.8) + fahrenheit;
                Console.WriteLine("{0} CELCİUS {1} FAHRENHEİT'TE EŞİTTİR...", celcius, sonuc);
            }
            Console.ReadKey();
        }
    }
}
