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

            // These examples assume a "C:\Users\Public\TestFolder" folder on your machine.
            // You can modify the path if necessary.

            // Example #1: Write an array of strings to a file.
            // Create a string array that consists of three lines.
           // string[] lines = { "First line", "Second line", "Third line" };

            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            //System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);

            // Example #2: Write one string to a text file.
           // string text = "A class is the most powerful data type in C#. Like a structure, " +
                         //  "a class defines the data and behavior of the data type. ";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            //System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);

            // Example #3: Write only some strings in an array to a file.
            // The using statement automatically flushes AND CLOSES the stream and calls
            // IDisposable.Dispose on the stream object.
            // NOTE: do not use FileStream for text files because it writes bytes, but StreamWriter
            // encodes the output as text.
          //  using (System.IO.StreamWriter file =
            //    new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt"))
            // {
               // foreach (string line in lines)
                // {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                   // if (!line.Contains("Second"))
                    // {
                       //  file.WriteLine(line);
                    // }
                // }
            // }

            // Example #4: Append new text to an existing file.
            // The using statement automatically flushes AND CLOSES the stream and calls
            // IDisposable.Dispose on the stream object.
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
