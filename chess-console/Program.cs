using board;
using chess;
using System;

namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessGame game = new ChessGame();

                while (!game.finished)
                {
                    Console.Clear();
                    Screen.boardPrinter(game.board);

                    Console.Write("Origin: ");
                    Position origin = Screen.readChessPosition().toPosition();
                    Console.Write("Destination: ");
                    Position destination = Screen.readChessPosition().toPosition();

                    game.moveExecute(origin, destination);
                }

                Screen.boardPrinter(game.board);
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
