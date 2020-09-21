using System.Collections.Generic;
using System;
using System.Linq;
using Pastel;
using System.Drawing;

namespace MasterMind
{
	public static class Logic
	{
		public static bool InputStringValidation(bool valid, List<string> guess, string colorOptions)
		{
			for ( var i = 0; i < guess.Count; i++)
			{
				if ( guess[i].Split().Any(x => !colorOptions.Contains(x)))
				{
					guess[i] = "";
					Console.WriteLine(" \n	Invalid guess input! \n 	Please choose from the given color input options. \n".Pastel(Color.DarkRed));
					return valid = false;
				}
			}
			return valid = true;
		}
		public static bool GuessCounterCheck(int guessCounter, bool tryChecker, string solution, string coloredSolution) 
		{
			if (guessCounter <= 9 && tryChecker) 
			{
				return Program.tryChecker = true;
			}
			if (guessCounter >= 10)
			{
				Console.WriteLine("\n" + "	Your've ran out of tryes!" + "\n".Pastel(Color.DarkRed));
				guessCounter = 0;
				Console.WriteLine("\n" + "	SOLUTION : ".Pastel(Color.LightGoldenrodYellow) + coloredSolution + "\n");
				return Program.tryChecker = false;
			}
			return false; 
		}
		public static bool CheckGuessAgainstSolution(
			List<string> convGuess,
			int guessCounter,
			int blackDot,
			int whiteDot,
			List<List<string>> hintList,
			string solution,
			string coloredSolution) 
		{
			List<string> solutionClone = solution.Select(s => s.ToString()).ToList();
			List<string> hintSubList = new List<string>();
			
			// BLACK and WHITE dot determination ==> HINTS:
			for (int i = 0; i < solutionClone.Count; i++)
			{
				hintSubList.Add("o".Pastel(Color.DarkSlateGray));
				if (convGuess[i] == solutionClone[i])
				{
					blackDot++;
					hintSubList.Insert(i, "B");
					solutionClone[i] = "?";
				}
				else if (convGuess.Contains(solutionClone[i]))
					{
						whiteDot++;
						hintSubList.Insert(i, "W");
						solutionClone[i] = "?";
					}
			}
			if ( hintSubList.Count > 4)
			{
				hintSubList.RemoveRange(4, hintSubList.Count - 4);
			}
			hintList.Insert(guessCounter, hintSubList);

			// WIN determination
			if (convGuess.SequenceEqual(solutionClone) || blackDot == 4)
			{
				Console.WriteLine("\n WIN \n");
				Console.WriteLine("\n" + "SOLUTION : " + Program.coloredSolution + "\n");
				return Program.tryChecker = false;
			}
				return Program.tryChecker;
		}
	}
}

	