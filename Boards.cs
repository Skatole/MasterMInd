using System;
using System.Collections.Generic;


namespace MasterMind
{
  public static class Boards
	{
		public static int columns = 4;
		public static int rows = 5;
		public static string memory = new string("");
		public static string[][] guessBoard = new string[rows][];
		public static string[][] hintBoard = new string[rows][];
		
		public static void DrawBoard()
		{
			for ( var i = 0; i < rows; i++ ) 
			{
				guessBoard[i] = new string[columns];
				for ( var j = 0; j < columns; j++) 
				{
					guessBoard[i][j] = "o";
				}
				for ( var x = 0; x < i; x++)
				{
					hintBoard[x] = new string[columns];
					for ( var y = 0; y < columns; y++) 
					{
						hintBoard[x][y] = "o";
					}
					Console.WriteLine( "|   " + String.Join("   |   ", guessBoard[i]) + "   |" + "    =>    " + "/   "+ String.Join("   /   ", hintBoard[x]) + "   /");
				}
			}
		}
		public static void OverrideBoard(List<string> memory, int guessCounter, int blackDot, int whiteDot)
		{
			for ( var i = 0; i < rows; i++ ) 
			{
				guessBoard[i] = new string[columns];
				for ( var j = 0; j < columns; j++) 
				{
					guessBoard[i][j] = "o";
					foreach (var memo in memory) guessBoard[guessCounter][j] = memo;
				}
				for ( var x = 0; x < i; x++)
				{
					hintBoard[x] = new string[columns];
					for ( var y = 0; y < columns; y++) 
					{
						hintBoard[x][y] = "o";
					}
			Console.WriteLine( "|   " + String.Join("   |   ", guessBoard[i]) + "   |" + "    =>    " + "/   "+ String.Join("   /   ", hintBoard[x]) + "   /");
				}
			}
  	}
	}
}