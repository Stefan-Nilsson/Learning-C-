using System;

namespace ExcerciseRps
{
    class Program
    {
        static bool again = true;
        static void Main(string[] args)
        {
            while (again)
            {
                Console.WriteLine("Pick rock, paper or scizzors!");
                string userInput;
                Random rnd = new Random();
                int cpuInput;
                cpuInput = rnd.Next(0, 4);
                userInput = Console.ReadLine();

                switch (cpuInput)
                {
                    case 1:
                        Console.WriteLine("ROCK");
                        if (userInput == "rock")
                        {
                            Console.WriteLine("it's a tie");
                        }
                        break;
                    case 2:
                        Console.WriteLine("PAPER");
                        if (userInput == "paper")
                        {
                            Console.WriteLine("it's a tie");
                        }
                        break;
                    default:
                        Console.WriteLine("SCIZZORS");
                        if (userInput == "scizzors")
                        {
                            Console.WriteLine("it's a tie");
                        }
                        break;
                }
                Console.WriteLine("if you want to quit press q otherwise press enter");
                     ConsoleKeyInfo cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q)
                    again = false;
            }
            
           
        }
    }
}
