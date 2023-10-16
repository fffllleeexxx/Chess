
using Chess.Chess;

char [,] board = new char[8, 8] 
{ {'r','n','b','q','k','b','n','r' },
  {'p','p','p','p','p','p','p','p' },
  {' ',' ',' ',' ',' ',' ',' ',' ' },
  {' ',' ',' ',' ',' ',' ',' ',' ' },
  {' ',' ',' ',' ',' ',' ',' ',' ' },
  {' ',' ',' ',' ',' ',' ',' ',' ' },
  {'P','P','P','P','P','P','P','P' },
  {'R','N','B','Q','K','B','N','R' }
};

char figure;


while (true)
{
    Print(board);

    Console.WriteLine("Напииште фигуру, которой хотите сходить, и напииште её координаты");
    int _x = Convert.ToInt32(Console.ReadLine());
    int _y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Напишите, куда хотите сходить");
    int _newX = Convert.ToInt32(Console.ReadLine());
    int _newY = Convert.ToInt32(Console.ReadLine());

    figure = board[_x, _y];

    if(figure == 'P')
    {
        Pawn pawn = new Pawn(_x, _y, board, _newX, _newY);
        pawn.Move(board, _x, _y, _newX, _newY);
    }


}



static void Print(char [,] board)
{
    for (int row = 0; row < 8; row++)
    {
        for (int col = 0; col < 8; col++)
        {
            Console.Write($"{board[row, col]}\t");
        }
        Console.WriteLine();
    }
}
