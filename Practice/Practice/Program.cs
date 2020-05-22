using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter an amount to fibbonaccify");
            int lengthInt;
            string length;
            length = Console.ReadLine();
            lengthInt = int.Parse(length);
            int a = 0, b = 1, c;
            Console.WriteLine("{0} {1}", a, b);
            
            for (int i = 0; i <= lengthInt; i++)
            {
                c = a + b;
                Console.WriteLine("{0}", c);
                a = b;
                b = c;
            }
        }
    }
}
