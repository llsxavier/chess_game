using board;

namespace chess
{
    class ChessGame
    {
        public Board board { get; private set; }
        private int turn;
        private Color activePlayer;
        public bool finished { get; private set; }

        public ChessGame()
        {
            board = new Board(8, 8);
            turn = 1;
            activePlayer = Color.White;
            finished = false;
            putPieces();
        }

        public void moveExecute(Position origin, Position destination)
        {
            Piece p = board.removePiece(origin);
            p.addMove();
            Piece tookPiece = board.removePiece(destination);
            board.putPiece(p, destination);
        }

        private void putPieces()
        {
            board.putPiece(new Rock(Color.White, board), new ChessPosition('c', 1).toPosition());
        }
    }
}
