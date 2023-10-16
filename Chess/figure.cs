
namespace Chess.Chess
{
    public class Figure
    {
        public int x;
        public int y;
        char[,] board = new char[8, 8];
        public int toX;
        public int toY;
        public Figure(int x, int y, char[,] board, int toX, int toY)
        {
            this.x = x;
            this.y = y;
            this.board = board;
            this.toX = toX;
            this.toY = toY;
        }

    }
}
