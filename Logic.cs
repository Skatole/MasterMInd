using System.Collections.Generic;
using System;
using System.Linq;
using Pastel;
using System.Drawing;

namespace MasterMind
{
	public static class Logic
	{
		public static bool InputStringValidation(bool validGuess, List<string> guess, string colorOptions)
		{
			if( guess.Count == 0)
			{
				Console.WriteLine(" \n	Invalid guess input! \n 	Please choose from the given color input options. \n".Pastel(Color.DarkRed));
				return validGuess = false;
			}
			for ( var i = 0; i < guess.Count; i++)
			{
			/* 	if ( guess[i] == "S")
					return validGuess = true; */
				if ( guess[i].Split().Any(x => !colorOptions.Contains(x)))
				{
					guess[i] = "";
					Console.WriteLine(" \n	Invalid guess input! \n 	Please choose from the given color input options. \n".Pastel(Color.DarkRed));
					return validGuess = false;
				}
			}
			return validGuess;
		}

	/* 	public static bool AutoSolverInitialised(bool autoSolverRequired, List<string> guess)
		{
			for ( var i = 0; i < guess.Count; i++)
			{
				if (guess.Contains("S"))
				{
					Console.WriteLine("AutoSolver initialised!".Pastel(Color.MediumVioletRed));
					return autoSolverRequired = true;
				}
			}
			return autoSolverRequired = false;
		} */
		public static bool GuessCounterCheck(int guessCounter, bool tryChecker, string solution, string coloredSolution) 
		{
			if (guessCounter < 9 && tryChecker) return tryChecker = true;
			if (guessCounter >= 9)
			{
				Console.WriteLine("\n" + "	Your've ran out of tryes!" + "\n".Pastel(Color.DarkRed));
				guessCounter = 0;
				Console.WriteLine("\n" + "	SOLUTION : ".Pastel(Color.LightGoldenrodYellow) + coloredSolution + "\n");
				return tryChecker = false;
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
			string coloredSolution,
			bool tryChecker) 
		{
			List<string> solutionClone = solution.Select(s => s.ToString()).ToList();
			List<string> hintSubList = new List<string>();
			
			// BLACK and WHITE dot determination ==> HINTS:
			for (int i = 0; i < solutionClone.Count; i++)
			{
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
				hintSubList.Add("o");
			}
			// cut the excess "o" and shuffle the hintList:
			if ( hintSubList.Count > 4) { hintSubList.RemoveRange(4, hintSubList.Count - 4); }
			
			Shuffler[] shuffledHintString = {string.Join("", hintSubList).ToString()};
			for (var j = 0; j < shuffledHintString.Length; j++) { hintList[guessCounter] = shuffledHintString[j].Shuffled.Select(h => h.ToString()).ToList(); }

			// WIN determination
			if (convGuess.SequenceEqual(solutionClone) || blackDot == 4)
			{
				Console.WriteLine("\n WIN \n");
				Console.WriteLine("\n" + "SOLUTION : " + coloredSolution + "\n");
				return tryChecker = false;
			}
				return tryChecker;
		}
	}
}

	