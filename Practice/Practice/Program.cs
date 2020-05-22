using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 7; i++)
            {
                int a = 3;
                Console.WriteLine(a *= a += a);
            }
        }
    }
}
