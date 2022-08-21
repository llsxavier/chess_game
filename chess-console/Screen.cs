﻿using System;
using board;

namespace chess_console
{
    class Screen
    {
        public static void boardPrinter(Board board)
        {
            for(int i=0; i<board.lines; i++)
            {
                for(int j=0; j<board.columns; j++)
                {
                    if(board.piece(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.piece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
