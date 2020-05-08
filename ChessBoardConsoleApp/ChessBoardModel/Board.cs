using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel
{
    class Board
    {
        // the size of the board usually 8x8
        // initial size of the board is defined by s.
        public int Size { get; set; }
        // create a new 2D array of type cell.
        public Cell[,] theGrid { get; set; }
        public Board(int s)
        {
            Size = s;

            theGrid = new Cell[Size, Size];
            // fill the 2D array with new Cells, each unique x and y coordinates
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }
    }
}
