using System;

namespace ClassConsoleOrneği
{
    class Person
    {
        public string Name;
        public int Height;
        public int Weight;
        private int Age;
        public Person(int h, int w, int a)
        {
            Height = h;
            Weight = w;
            Age = a;
        }
        public Person(int h, int w)
        {
            Height = h;
            Weight = w;
            Age = 21;
        }
        public void Me()
        {
            Console.WriteLine(" {0} Age {1} Weight {2} Height {3}", Name, Age, Weight, Height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Bedirhan = new Person(174, 76, 21);
            Bedirhan.Name = "Bedirhan";           
            Bedirhan.Me();
            Console.ReadKey();
        }
    }
}
