

public class Board
{
    private int[,] board;

    public int Rows { get; private set; }
    public int Columns { get; private set; }

    public Board(int rows = 20, int columns = 10)
    {
        Rows = rows;
        Columns = columns;
        board = new int[Rows, Columns];
        ClearBoard();
    }

    public void ClearBoard()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                board[i, j] = 0;
            }
        }
    }

    public void CheckersFill()
    {
        bool flag = true;
        for (int i = 0; i < Columns; i++)
        {
            for (int j = 0; j < Ro; j++)
            {
                if (flag)
                {
                    board[i, j] = 1; flag = false;
                }
                else
                {
                    board[i, j] = 0; flag = true;
                }

            }
        }
    }

    public void FillBoard(int tetrominoId = 0)
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                board[i, j] = tetrominoId;
            }
        }
    }

    public void FillWithColors()
    {
        int count = 1;
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                if (count > 9)
                {
                    count = 1;
                }
                board[i, j] = count;
                count++; 
            }
        }
    }

    public static Board GenerateBoard() //! Terminar
    {
        return new Board();
    }

    public int GetCellValue(int row, int column, Board board)
    {
        return board.board[row, column];
    }
}
