using System;
using System.Collections.Generic;
using System.Text;

namespace ChessboardTry2
{
    public class Chessboard
    {
        private string[,] chessBoard;
        public const int DIMENSION = 8; // original 8x8 board

        // pawn doesn't need to initialize because Move inherits Pawn, hence it also gets initialized

        private Move move;

        public Chessboard()
        {

            move = new Move();
            chessBoard = new string[DIMENSION, DIMENSION];
            ChessBoardHorizontalSymbol = "+---";
            ChessBoardVerticalSymbol = "| ";
        }


        public string ChessBoardHorizontalSymbol { get; set; }
        public string ChessBoardVerticalSymbol { get; set; }

        public void displayChessBoard()
        {
            // while(!move.Exit)
            // {
            Console.Clear();
            // header for the columns: x axis header
            Console.WriteLine("    0   1   2   3   4   5   6   7");

            // rows
            for (int r = 0; r < DIMENSION; r++)
            {
                // left spacing - 2 spaces
                Console.Write("  ");
                // symbol it's self chessboard horizontal symbal variable
                for (int c = 0; c < DIMENSION; c++)
                {
                    Console.Write(ChessBoardHorizontalSymbol); // write the horizontal pattern
                }
                // \n = next line
                // c = loop vertical symbols
                Console.Write("+\n");

                for (int c = 0; c < DIMENSION; c++)
                {
                    // so the header shows only once
                    if (c == 0)
                    {
                        Console.Write(r + " "); // y axis header
                    }
                    // display the pawn neatly centered (space at the end of the following line)
                    Console.Write(ChessBoardVerticalSymbol + Pawn.pawns[r, c] + " ");

                }
                // next line
                Console.Write("|\n");
            }
            // the bottom line needs to be printed separately
            Console.Write("  "); // left spacing
            for (int c = 0; c < DIMENSION; c++)
            {
                Console.Write(ChessBoardHorizontalSymbol);
            }
            // the + at the end 
            Console.Write("+\n\n");

            //}
        }
    }
}
