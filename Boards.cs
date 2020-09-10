using System;
using System.Linq;

namespace MasterMind
{
  public static class Boards
	{
   	public static int columns = 8;
		public static int rows = 5;

		public static string[][] guessBoard = new string[rows][];
		public static string[][] hintBoard = new string[rows][];

		
		public static void DrawBoard()
		{
			for ( var i = 0; i < rows; i++ ) 
			{
				guessBoard[i] = new string[columns - 3];
				for ( var j = 0; j < columns - 3; j++) 
				{
					guessBoard[i][j] = " o ";
				}
				for ( var x = 0; x < i; x++)
				{
					hintBoard[x] = new string[columns - 3];
					for ( var y = 0; y < columns - 3; y++) 
					{
						hintBoard[x][y] = " o ";
					}
					Console.WriteLine( "|" + String.Join("|", guessBoard[i]) + "|" + "/" + String.Join("/", hintBoard[x]) + "/");
				}
			}
		}
  }
}