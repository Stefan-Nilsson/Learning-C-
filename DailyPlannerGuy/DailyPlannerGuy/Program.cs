using System;

namespace DailyPlannerGuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("Hello I'm DailyPlannerGuy but you can call me DailyPlannerGuy.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Everyday when starting your day I will help put some structure in your feelings, thoughts, and plans.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Anyhow, enough about me, lets talk about you.");
            Console.ReadKey();
            Console.Clear();

            // Create a string variable and get user input from the keyboard and store it in the variable
            Console.WriteLine("How awesome are you feeling today?");
            string feelings = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What will you do today?");
            string generalPlan = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please sum them up in 10 small doable and concrete steps");
           

            Console.WriteLine("1: ");
            string partOne = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("2: ");
            string partTwo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("3: ");
            string partThree = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("4: ");
            string partFour = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("5: ");
            string partFive = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("6: ");
            string partSix = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("7: ");
            string partSeven = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("8: ");
            string partEight = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("9: ");
            string partNine = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("10: ");
            string partTen = Console.ReadLine();
            Console.Clear();









            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("You are feeling " + feelings);
            Console.WriteLine("But the thing is, good, bad, it's all the same in the end.");
            Console.WriteLine("Just do what you can do even if it's not much and even if you don't feel like it.");
            Console.WriteLine("It's better to practice or do a little bit everyday then to let it all slip away");
            Console.WriteLine("Just go for it!");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("anyhow here's a summary of today's feelings, thoughts and plans:");

            Console.WriteLine(generalPlan);
            Console.WriteLine(partOne);
            Console.WriteLine(partTwo);
            Console.WriteLine(partThree);
            Console.WriteLine(partFour);
            Console.WriteLine(partFive);
            Console.WriteLine(partSix);
            Console.WriteLine(partSeven);
            Console.WriteLine(partEight);
            Console.WriteLine(partTen);

            Console.ReadLine();

        
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\FeelingsThoughtsPlansLog.txt", true))
            {
                file.WriteLine(feelings);
                file.WriteLine(generalPlan);
                file.WriteLine(partOne);
                file.WriteLine(partTwo);
                file.WriteLine(partThree);
                file.WriteLine(partFour);
                file.WriteLine(partFive);
                file.WriteLine(partSix);
                file.WriteLine(partSeven);
                file.WriteLine(partEight);
                file.WriteLine(partTen);
            }
        }
    }
}
