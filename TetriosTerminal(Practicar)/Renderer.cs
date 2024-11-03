using System;
using System.Drawing;

namespace TetriosTerminal_Practicar_
{
	public class Renderer
	{
		private static int[] UI_HoldOffset;
		private static int[] UI_BoardOffset;
		private static int[] UI_Next;
		private static int[] UI_BoardContainer;
		private static int BufferMiddle = Console.BufferWidth / 2;

		// Constructor
		public Renderer()
		{

			UI_HoldOffset = new int[] { 0, 4 };
			UI_BoardOffset = new int[] { 12, 4 };
			UI_Next = new int[] { 0, 4 };
			UI_BoardContainer = new int[] { UI_BoardOffset[0] - 2, UI_BoardOffset[1] };

			Console.SetBufferSize(120, 40);
		}

		public static void RenderBoard(Board board)
		{
			Console.ForegroundColor = ConsoleColor.White;
			bool oneTimeRender = true;
			if (oneTimeRender)
			{
				RenderBoardContainer(board);
				RenderDrawHold(board);
				oneTimeRender = false;
			}
			RenderDrawGameBoard(board);
		}

		private static void RenderDrawGameBoard(Board board)
		{
			Console.ForegroundColor = ConsoleColor.DarkGray;
			for (int i = 0; i < board.Rows; i++)
			{
				for (int j = 0; j < board.Columns; j++)
				{
					int cellValue = board.GetCellValue(i, j, board);

					Console.SetCursorPosition(i * 2 + UI_BoardOffset[0], j + UI_BoardOffset[1]);
					Console.Write(cellValue == 0 ? "_|" : "[]");
				}
			}
			Console.ResetColor();
		}

		private static void RenderDrawHold(Board board)
		{
			Console.SetCursorPosition(UI_HoldOffset[0], UI_HoldOffset[1]);
			Console.Write(Graphics.Graphics_HoldUI);
		}

		private static void RenderBoardContainer(Board board)
		{
			Console.SetCursorPosition(UI_BoardContainer[0], UI_BoardContainer[1]);
			Console.Write(Graphics.Graphics_ContainerUI);
		}
	}
}
