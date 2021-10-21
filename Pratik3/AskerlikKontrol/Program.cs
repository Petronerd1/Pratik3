using System;

namespace AskerlikKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender;
            int age;
            Console.Write("Enter Gender (M/F):");
            gender = Console.ReadLine();
            Console.Write("Enter Age");
            age = Convert.ToInt16(Console.ReadLine());
            if (gender == "M" && age > 19) 
            {
                Console.WriteLine("Suitable");
            }
            else
            {
                Console.WriteLine("Not Suitable");
            }
            Console.ReadKey();
        }
    }
}
