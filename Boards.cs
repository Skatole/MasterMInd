using System;
using System.Collections.Generic;


namespace MasterMind
{
  public static class Boards
	{
		public static int columns = 4;
		public static int rows = 10;
		public static string memory = new string("");
		
		public static void DrawBoard(List<List<string>> memory, int guessCounter, int blackDot, int whiteDot)
		{
		 List<List<string>> guessBoard = new List<List<string>>();
		 List<List<string>> hintBoard = new List<List<string>>();
			for (var i = 0; i < rows; i++)
			{
				List<string> subRowList = new List<string>();
				for ( var j = 0; j < columns; j++)
				{
					subRowList.Add("o");
					if ( guessCounter >= 0)
					{
						guessBoard[guessCounter][j] = memory[guessCounter][j];
					}
				}
				guessBoard.Add(subRowList);
				hintBoard.Add(subRowList);
			}
			Print(guessBoard, hintBoard);
		}
		public static void Print ( List<List<string>> guess, List<List<string>> hint)
		{
			Console.WriteLine("\n");
			for ( var i = 0; i < guess.Count; i++)
			{
				Console.WriteLine(  "|   " + String.Join("   |   ", guess[i]) + "   |" + "    =>    " + "/   "+ String.Join("   /   ", hint[i]) + "   /");
			}
			Console.WriteLine("\n");
			guess = null;
			hint = null;
		}
  } 
}