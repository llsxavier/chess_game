using board;
using System;

namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Board B;

            B = new Board(8, 8);

            Console.WriteLine("Position: " + B);
            Console.ReadLine();
        }
    }
}
