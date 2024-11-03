

public class Board
{
	private int[,] board;

	public int Rows { get; private set; }
	public int Columns { get; private set; }

	public Board(int rows = 10, int columns = 20)
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
		for (int i = 0; i < Rows; i++)
		{
			for (int j = 0; j < Columns; j++)
			{
				if (flag)
				{
					board[i, j] = 1; flag = false;
				}
				else
				{
					board[i, j] = 0; flag = true ;
				}

			}
		}
	}

	public void FillBoard()
	{
		for (int i = 0; i < Rows; i++)
		{
			for (int j = 0; j < Columns; j++)
			{
				board[i, j] = 1;
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
