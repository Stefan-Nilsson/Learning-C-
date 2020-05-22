using System;
using System.Dynamic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter amount of times I should fibbonaccify");
            string length;
            int lengthInt;
            int a = 0, b = 1, c;
            length = Console.ReadLine();
            lengthInt = int.Parse(length);
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
