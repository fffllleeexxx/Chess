

namespace Chess.Chess
{
    public class Pawn:Figure
    {
        public Pawn(int x, int y, char[,] board, int toX, int toY):base(x, y, board, toX, toY) { }

        public void Move(char[,] board, int x, int y, int toX, int toY)
        {
            if (toX == x && toY == y+1)
            {
                char i = board[toX, toY];
                board[toX, toY] = board[x,y];
                board[x,y] = i;

            }
            else if (board[x,y]!='P' || board[x,y]!='p')
            {
                Console.WriteLine("Нет пешки на начальной клетке");
            }
            else { Console.WriteLine("Неправтльный ход для пешки"); }
        }

    }
}
