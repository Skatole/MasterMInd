using System;
using System.Collections.Generic;
using System.Drawing;
using Pastel;

namespace MasterMind
{
	public class Boards
	{
		public void DrawBoard(List<List<string>> memory, int guessCounter, List<List<string>> hintList, int rows, int columns)
		{
			for (var i = 0; i < rows; i++)
			{
				List<string> subGuessRowList = new List<string>();
				List<string> subHintRowList = new List<string>();
				for (var j = 0; j < columns; j++)
				{
					subGuessRowList.Add("o".Pastel(Color.DarkSlateGray));
					subHintRowList.Add("o".Pastel(Color.DarkSlateGray));
				}
				memory.Add(subGuessRowList);
				hintList.Add(subHintRowList);
				if (memory.Count > 10) memory.RemoveRange(10, memory.Count - 10);
				if (hintList.Count > 10) hintList.RemoveRange(10, hintList.Count - 10);
			}
			Print(memory, hintList, guessCounter, rows, columns);
		}


		public void Print(List<List<string>> guess, List<List<string>> hint, int guessCounter, int rows, int columns)
		{
			for (var i = 0; i < rows; i++)
			{
				for (var j = 0; j < columns; j++)
				{
					switch (guess[i][j])
					{
						case "B": guess[i][j] = "o".Pastel(Color.Blue); break;
						case "C": guess[i][j] = "o".Pastel(Color.Cyan); break;
						case "R": guess[i][j] = "o".Pastel(Color.Red); break;
						case "G": guess[i][j] = "o".Pastel(Color.Green); break;
						case "Y": guess[i][j] = "o".Pastel(Color.Yellow); break;
						case "W": guess[i][j] = "o".Pastel(Color.White); break;
						case "P": guess[i][j] = "o".Pastel(Color.Purple); break;
					}
					switch (hint[i][j])
					{
						case "B": hint[i][j] = "o".Pastel(Color.Black); break;
						case "W": hint[i][j] = "o".Pastel(Color.White); break;
						case "o": hint[i][j] = "o".Pastel(Color.DarkSlateGray); break;
					}
				}
				// Console.WriteLine("\n");
		
				Console.WriteLine(
				"	"
				+ "|   ".Pastel(Color.DarkSlateGray)
				+ String.Join("   |   ".Pastel(Color.DarkSlateGray), guess[i])
				+ "   |".Pastel(Color.DarkSlateGray)
				+ "    =>    ".Pastel(Color.DarkSlateGray)
				+ "(   ".Pastel(Color.DarkSlateGray)
				+ String.Join("   )(   ".Pastel(Color.DarkSlateGray), hint[i])
				+ "   )".Pastel(Color.DarkSlateGray));
			
				Console.WriteLine("\n");
			}
		}
	}
}