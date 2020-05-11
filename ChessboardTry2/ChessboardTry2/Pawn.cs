using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;

namespace ChessboardTry2
{
    class Pawn
    {
        public Constant char PAWN_SYMBOL = 'X';
        public const char SPACE = ' ';
        public static char[,] pawns;

        public Pawn()
        {
            pawns = new char[Chessboard.DIMENSION, Chessboard.DIMENSION];
        }
    }
}
