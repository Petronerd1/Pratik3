using System;

namespace UserControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            Console.Write("User Name : ");
            username = Console.ReadLine();
            Console.Write("Password : ");
            password = Console.ReadLine();

            if(username=="Petro"&& password=="1234")
            {
                Console.Write("Login Success");
            }
            else
            {
                Console.Write("Login Failed");
            }
            Console.ReadKey();
        }
    }
}
