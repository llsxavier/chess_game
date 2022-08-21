using board;

namespace chess
{
    class Rock : Piece
    {
        public Rock(Color color, Board board) : base(color, board)
        { }
        public override string ToString()
        {
            return "R";
        }
    }
}
