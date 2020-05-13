using System;
using System.Collections.Generic;
using System.Text;

namespace ChessboardTry2
{
    public class Move : Pawn
    {
        private int targetX;
        private int targetY;
        private int destinationX;
        private int destinationY;

        public Move()
        {
            targetX = 0;
            targetY = 0;
            destinationX = 0;
            destinationY = 0;
            Exit = false;
        }

        public bool Exit { get; set; }

        public void MakeMove()
        {
            getInput();

            rearrangePawns();
        }
        private void getInput()
        {
        //get input and validate it
        // the program runs untill user enters invalid input.

        Console.WriteLine("Enter Target's X axis");

            Exit = validateInput(int.TryParse(Console.ReadLine(), out targetX));

            // if we passed the previous validation, move to the next coordinates
            if (!Exit)
            {
                Console.WriteLine("Enter Target's Y axis");

                Exit = validateInput(int.TryParse(Console.ReadLine(), out targetY));
            }
            if (!Exit)
            {
                Console.WriteLine("Enter destination's X axis");

                Exit = validateInput(int.TryParse(Console.ReadLine(), out destinationX));
            }
            if (!Exit)
            {
                Console.WriteLine("Enter destination's Y axis");

                Exit = validateInput(int.TryParse(Console.ReadLine(), out destinationY));
            }
        }
        private bool validateInput(bool parsed)
    { // here i would probably have to write the piece logic no? something like
            // if targetX = PAWN then only this and that is allowed. otherwise throw error.
            bool error = false;

            if(!parsed)
            {
                error = true;
            }
            else if (targetX < 0  || targetY < 0 || destinationX < 0 || destinationY < 0)
            {
                error = true;
            }
            // why this instead of 7 hard code? this way we can change the dimension and it will still work
            else if (targetX > Chessboard.DIMENSION - 1 || targetY > Chessboard.DIMENSION - 1 || destinationX > Chessboard.DIMENSION - 1 || destinationY > Chessboard.DIMENSION - 1)
            {
                error = true;
            }
                
            if (error)
                Console.WriteLine("Invalid input. Exiting program now!");

    return error;
    }
    private void rearrangePawns()
    {
            // place the symbol of the target into the destination coordinates
            pawns[destinationX, destinationY] = pawns[targetX, targetY];
            // set the target symbol to space
            pawns[targetX, targetY] = SPACE;

        }

   }
}