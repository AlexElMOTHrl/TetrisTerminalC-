using TetriosTerminal_Practicar_;

class Game
{
	private Board board;
	private Tetromino currentPiece;
	private InputHandler inputHandler;
	private Renderer renderer;

	private bool isRunning;

	public Game()
	{
		board = new Board();
		inputHandler = new InputHandler();
		renderer = new Renderer();
		isRunning = true;

		board.ClearBoard();
	}

	public void Start()
	{
		Console.Clear();
		while (isRunning)
		{
			Update();
			Renderer.RenderBoard(board);
			Thread.Sleep(1);
		}
	}

	private void Update()
	{

	}
}
