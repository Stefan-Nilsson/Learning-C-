using ChessBoardModel;
using System;

namespace ChessBoardConsoleApp
{
    class Program
    {
        static Board myBoard = new Board(8);
        static void Main(string[] args)
        {
            // show the empty chess board
            printBoard(myBoard);
            // ask the user for an x and y coordinate where we will place a piece

            // calculate all legal moves for that piece

            // print the chess board. Use an X for occupied squire. Use a + for legal move. Use . for empty cell.

            // wait for another enter key press before ending the program.
        }

        private static void printBoard(Board myBoard)
        {
            // first for loop = for each row/ one row at a time
            // print the chess board to the console. Use X for the piece location. + for legal move. . for empty square
            for (int i = 0; i < myBoard.Size; i++)
            {
                // second for loop = one collumn at a time
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.theGrid[i, j];

                    if (c.CurrentlyOccupied == true)
                    {
                        Console.Write("x");
                    }
                    else if (c.LegalNextMove == true)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("=======================");
        }
    }
}
