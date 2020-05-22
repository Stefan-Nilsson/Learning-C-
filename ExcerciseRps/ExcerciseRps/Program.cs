using System;

namespace ExcerciseRps
{
    class Program
    {
        static bool again = true;
        static void Main(string[] args)
        {
            int userScore = 0;
            int computerScore = 0;
            while (again)
            {
                Console.Clear();
                Console.WriteLine("userscore :{0} computerscore:{1}", userScore, computerScore);
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
                        else if (userInput == "paper")
                        {
                            Console.WriteLine("you have won this round");
                            userScore++;
                        }
                        else if (userInput == "scizzors")
                        {
                            Console.WriteLine("you have lost this round");
                            computerScore++;
                        }
                        else
                        {
                            Console.WriteLine("input was not valid");
                        }                            
                        break;
                    case 2:
                        Console.WriteLine("PAPER");
                        if (userInput == "rock")
                        {
                            Console.WriteLine("you have lost this round");
                            computerScore++;
                        }
                        else if (userInput == "paper")
                        {
                            Console.WriteLine("it's a tie");
                        }
                        else if (userInput == "scizzors")
                        {
                            Console.WriteLine("you have won this round");
                            userScore++;
                        }
                        else
                        {
                            Console.WriteLine("input was not valid");
                        }
                        break;
                    default:
                        Console.WriteLine("SCIZZORS");
                        if (userInput == "rock")
                        {
                            Console.WriteLine("you have won this round");
                            userScore++;
                        }
                        else if (userInput == "paper")
                        {
                            Console.WriteLine("you have lost this round");
                            computerScore++;
                        }
                        else if (userInput == "scizzors")
                        {
                            Console.WriteLine("it's a tie");
                        }
                        else
                        {
                            Console.WriteLine("input was not valid");
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
