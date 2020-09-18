using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using Pastel;

namespace MasterMind
{
  public static class Boards
	{
		public static int columns = 4;
		public static int rows = 10;

		public static void DrawBoard(List<List<string>> memory, int guessCounter, List<List<string>> hintList )
		{
			for (var i = 0; i < rows; i++)
			{
				List<string> subGuessRowList = new List<string>();
				List<string> subHintRowList = new List<string>();
				for ( var j = 0; j < columns; j++)
				{
					subGuessRowList.Add("o".Pastel(Color.DarkSlateGray));
					subHintRowList.Add("o".Pastel(Color.DarkSlateGray));
				}
				memory.Add(subGuessRowList);
				hintList.Add(subHintRowList);
				if (memory.Count > 10) memory.RemoveRange(10, memory.Count - 10);
				if (hintList.Count > 10) hintList.RemoveRange(10, hintList.Count - 10);
			}
			Print(memory, hintList);
		}

		
		public static void Print ( List<List<string>> guess, List<List<string>> hint)
		{
			if (guess.Count > 0) 
			{
			for ( var i = 0; i < rows; i++)
			{
				for ( var j = 0; j < columns; j++)
				{
					switch(guess[i][j])
					{
						case "B":
							guess[i][j] = "o".Pastel(Color.Blue);
							break;
						case "C":
							guess[i][j] = "o".Pastel(Color.Blue);
							break;
						case "R":
							guess[i][j] = "o".Pastel(Color.Blue);
							break;
						case "G":
							guess[i][j] = "o".Pastel(Color.Blue);
							break;
						case "Y":
							guess[i][j] = "o".Pastel(Color.Blue);
							break;
						case "W":
							guess[i][j] = "o".Pastel(Color.Blue);
							break;
						case "P":
							guess[i][j] = "o".Pastel(Color.Blue);
							break;
						default: guess[i][j] = "o".Pastel(Color.Blue); break;
					}
				}
			}
			}
			var spectrum = new (string color, string letter)[]
			{
			    ("#124542", letter),
			    ("#185C58", "b"),
			    ("#1E736E", "c"),
			    ("#248A84", "d"),
			    ("#20B2AA", "e"),
			    ("#3FBDB6", "f"),
			    ("#5EC8C2", "g"),
			    ("#7DD3CE", "i"),
			    ("#9CDEDA", "j"),
			    ("#BBE9E6", "k")
			};

var spectrumString = (string.Join("", spectrum.Select(s => s.letter.Pastel(s.color))));
			Console.WriteLine("\n");
			for ( var i = 0; i < guess.Count; i++)
			{
				Console.WriteLine( "	"
				+ "|   ".Pastel(Color.DarkSlateGray)
				+ String.Join("   |   ".Pastel(Color.DarkSlateGray), guess[i])
				+ "   |".Pastel(Color.DarkSlateGray)
				+ "    =>    ".Pastel(Color.DarkSlateGray)
				+ "(   ".Pastel(Color.DarkSlateGray)
				+ String.Join("   )(   ".Pastel(Color.DarkSlateGray), hint[i])
				+ "   )".Pastel(Color.DarkSlateGray) + "\n");
			}
			
			guess = null;
			hint = null;
			Console.WriteLine("\n");
		}
  }  
}