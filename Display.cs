using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using Pastel;

namespace MasterMind
{
	public class Display
	{
		private List<List<string>> guessStringList = new List<List<string>>();
		private List<List<string>> hintStringList = new List<List<string>>();
		private List<string> solutionStringList = new List<string>();
		public void Print(Variables variables)
		{
			PecekConverter guessConverter = new PecekConverter();
			PecekConverter hintConverter = new PecekConverter();
			PecekConverter solutionConverter = new PecekConverter();

			// solutionStringList = pecekConverter.PecekToColor(variables, variables.solution);
				solutionStringList = (solutionConverter.PecekToColor(variables, variables.solution));

				for (var i = 0; i < variables.rows; i++)
				{
					List<string> subGuessRowList = new List<string>();
					List<string> subHintRowList = new List<string>();
					for (int j = 0; j < variables.columns; j++)
					{
						subGuessRowList.Add("o".Pastel(Color.DarkSlateGray));
						subHintRowList.Add("o".Pastel(Color.DarkSlateGray));
					}
					guessStringList.Add(subGuessRowList);
					hintStringList.Add(subHintRowList);
					if (guessStringList.Count > variables.rows) { guessStringList.RemoveRange(variables.rows, guessStringList.Count - variables.rows); }
					if (hintStringList.Count > variables.rows) hintStringList.RemoveRange(variables.rows, hintStringList.Count - variables.rows);
				
					// 	switch (variables.guessMemory[i][j])
					// 	{
					// 		case PecekColor.Blue: guess[i][j] = "o".Pastel(Color.Blue); break;
					// 		case "C": guess[i][j] = "o".Pastel(Color.Cyan); break;
					// 		case "R": guess[i][j] = "o".Pastel(Color.Red); break;
					// 		case "G": guess[i][j] = "o".Pastel(Color.Green); break;
					// 		case "Y": guess[i][j] = "o".Pastel(Color.Yellow); break;
					// 		case "W": guess[i][j] = "o".Pastel(Color.White); break;
					// 		case "P": guess[i][j] = "o".Pastel(Color.Purple); break;
					// 	}
					// 	switch (hint[i][j])
					// 	{
					// 		case "B": hint[i][j] = "o".Pastel(Color.Black); break;
					// 		case "W": hint[i][j] = "o".Pastel(Color.White); break;
					// 		case "o": hint[i][j] = "o".Pastel(Color.DarkSlateGray); break;
					// 	}
					// }


				}
				// FOR the first board draw when there si no guess input jet it throws a NullRefEx. ===> NEEDS SOLVING!!!!
				// if (variables.guessMemory[variables.guessCounter].Length != 0 && variables.hintArr[variables.guessCounter].Length != 0)
				// {
				// }
					guessStringList[variables.guessCounter] = guessConverter.PecekToColor(variables, variables.guessMemory[variables.guessCounter]);
					hintStringList[variables.guessCounter] = hintConverter.PecekToColor(variables, variables.hintArr[variables.guessCounter]);

				for ( int i = 0; i < variables.rows; i++)
				{
						Console.WriteLine(
					"	"
					+ "|   ".Pastel(Color.DarkSlateGray)
					+ String.Join("   |   ".Pastel(Color.DarkSlateGray), guessStringList[i])
					+ "   |".Pastel(Color.DarkSlateGray)
					+ "    =>    ".Pastel(Color.DarkSlateGray)
					+ "(   ".Pastel(Color.DarkSlateGray)
					+ String.Join("   )(   ".Pastel(Color.DarkSlateGray), hintStringList[i])
					+ "   )".Pastel(Color.DarkSlateGray));
					Console.WriteLine("\n");
				}

			
					if (variables.guessCounter >= 9)
					{
						Console.WriteLine("\n" + "	Your've ran out of tryes!".Pastel(Color.DarkRed) + "\n".Pastel(Color.DarkRed));
						Console.WriteLine("\n" + "	SOLUTION :	".Pastel(Color.LightGoldenrodYellow) + string.Join("	", solutionStringList) + "\n");
					}
					if (variables.guessMemory[variables.guessCounter].SequenceEqual(variables.solution) && variables.isTryValid == false)
					{
						Console.WriteLine("\n	WIN \n");
						Console.WriteLine("\n" + "	SOLUTION :	".Pastel(Color.LightGoldenrodYellow) + string.Join("	", solutionStringList) + "\n");
					}
				
		}
	}
}