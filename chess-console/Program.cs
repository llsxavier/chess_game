using board;
using chess;
using System;

namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Board B = new Board(8, 8);

            B.putPiece(new Rock(Color.Black, B), new Position(0, 0));
            B.putPiece(new Rock(Color.Black, B), new Position(1, 3));
            B.putPiece(new King(Color.Black, B), new Position(2, 4));

            Screen.boardPrinter(B);
        }
    }
}
