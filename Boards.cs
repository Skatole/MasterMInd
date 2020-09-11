using System;
using System.Text.RegularExpressions;
using System.Linq;

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
					guessBoard[i][j] = " o ";
				}
				for ( var x = 0; x < i; x++)
				{
					hintBoard[x] = new string[columns];
					for ( var y = 0; y < columns; y++) 
					{
						hintBoard[x][y] = " o ";
					}
					Console.WriteLine( "|" + String.Join("|", guessBoard[i]) + "|" + "  =>  /" + String.Join("/", hintBoard[x]) + "/");
				}
			}
		}

		public static string OverrideBoard(string guess, int guessCounter, int blackDot, int whiteDot)
		{
			// insert spaces into the guess string

			for (int i = 1; i <= guess.Length; i += 1)
        {
            guess = guess.Insert(i, " ");
            i++;
        }
			string[] col = guessBoard.Select(rows => rows[guessCounter]).ToArray();
			col = guess.Split(" ").ToArray();
			guessCounter++;	
			for ( var i = 0; i < rows; i++ ) 
			{
				guessBoard[i] = new string[columns];
				for ( var j = 0; j < columns; j++) 
				{
					guessBoard[i][j] = "o";
					guessBoard[guessCounter][j] = col[j];
				}
				for ( var x = 0; x < i; x++)
				{
					hintBoard[x] = new string[columns];
					for ( var y = 0; y < columns; y++) 
					{
						hintBoard[x][y] = "o";
					}
					memory = "| " + String.Join(" | ", guessBoard[i]) + " |" + "  =>  / " + String.Join(" / ", hintBoard[x]) + " /";
					Console.WriteLine( memory );
				}
			}
			return memory;
		}
  }
}