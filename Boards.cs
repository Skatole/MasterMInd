using System;
using System.Collections.Generic;


namespace MasterMind
{
  public static class Boards
	{
		public static int columns = 4;
		public static int rows = 10;
		public static void DrawBoard(List<List<string>> memory, int guessCounter, int blackDot, int whiteDot, List<List<string>> hintList )
		{
			for (var i = 0; i < rows; i++)
			{
				List<string> subGuessRowList = new List<string>();
				List<string> subHintRowList = new List<string>();
				for ( var j = 0; j < columns; j++)
				{
					subGuessRowList.Add("o");
					subHintRowList.Add("o");
				}
				memory.Add(subGuessRowList);
				hintList.Add(subHintRowList);
				if (memory.Count > 10) memory.RemoveRange(10, memory.Count - 10);
				if (hintList.Count > 10) hintList.RemoveRange(10, hintList.Count - 10);
			}
			// the hint board fill
		/* 	for (var i = 0; i < rows; i++)
			{
				List<string> subRowList = new List<string>();
			
				for ( var j = 0; j < columns; j++)
				{
					subRowList.Add("o");
				}
				hintBoard.Add(subRowList);
			} */
			Print(memory, hintList);
		}
		public static void Print ( List<List<string>> guess, List<List<string>> hint)
		{
			
			Console.WriteLine("\n");
			for ( var i = 0; i < guess.Count; i++)
			{
				Console.WriteLine(  "|   " + String.Join("   |   ", guess[i]) + "   |" + "    =>    " + "(   "+ String.Join("   )(   ", hint[i]) + "   )");
			}
			
			guess = null;
			hint = null;
			Console.WriteLine("\n");
		}
  }  
}