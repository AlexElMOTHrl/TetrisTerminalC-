
using TetriosTerminal_Practicar_;

internal class Program
{
	private static void Main(string[] args)
	{
		Thread.Sleep(1000);
		Console.WriteLine("Tetris Iniciando...");
		Game game = new Game();
		game.Start();
	}
}