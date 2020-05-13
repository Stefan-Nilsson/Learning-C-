using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;

namespace ChessboardTry2
{
    public class Pawn
    {
        public const char PAWN_SYMBOL = 'X';
        public const char KNIGHT_SYMBOL = 'K';
        public const char SPACE = ' ';
        public static char[,] pawns;

        public Pawn()
        {
            // constructor, when the pawn gets initialized through the Move (inherit stuff)
            // it will create the array and also the initPawn method
            pawns = new char[Chessboard.DIMENSION, Chessboard.DIMENSION];
            initPawn(); // populate pawn array with X and Spaces
        }
        // method won't be used anywhere else so void?
        private void initPawn()
        {
            for (int r = 0; r < Chessboard.DIMENSION; r++)
            {
                for (int c = 0; c < Chessboard.DIMENSION; c++)
                {
                    //place X into first 2 and last 2 rows of the array
                    if (r == 0 || r == 1 || r == Chessboard.DIMENSION - 2 || r == Chessboard.DIMENSION - 1)
                    {
                        pawns[r, c] = PAWN_SYMBOL;
                    }
                    else
                    {
                        pawns[r, c] = SPACE;
                    }
                    // this is if u want the correct representation of the pawns
                    // if (r == 1 || r == Chessboard.DIMENSION - 2)
                    // {
                    //    pawns[r, c] = PAWN_SYMBOL;
                    // }
                    // this is for pin pointing the pieces, in this case the knight in the left upper corner
                    //  else if (r == 0 & c == 0)
                    //   {
                    //      pawns[r, c] = KNIGHT_SYMBOL;
                    //   }
                    
                }
            }
        }
    }
}
