﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChessboardTry2
{
   public class Chessboard
    {
        private string[,] chessBoard;
        public const int DIMENSION = 8; // original 8x8 board

        private Pawn pawn;
        private Move move;
        
        public Chessboard()
        {
            pawn = new Pawn();
            move = new Move();
            chessBoard = new string[DIMENSION, DIMENSION];
            ChessBoardHorizontalSymbol = "+---";
            ChessBoardVerticalSymbol = "| ";
        }
        public string ChessBoardHorizontalSymbol { get; set; }
        public string ChessBoardVerticalSymbol { get; set; }
    }
}
