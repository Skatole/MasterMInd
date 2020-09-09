using System;

namespace Board

{
  class Boards
	{
   	static int columns = 8;
		static int rows = 10;

		string[][] board = new string[rows][];

		
		public void DrawBoard()
		{
		for ( var i = 0; i < rows; i++ ) 
		{
			board[i] = new string[columns - 3];
			for ( var j = 0; j < columns - 3; j++) 
			{
			board[i][j] = " o ";
			}
			Console.WriteLine( "|" + String.Join("|", board[i]) + "|" + "/" + String.Join("/", board[i]) + "/");
		}
		return;
		}
  }
}