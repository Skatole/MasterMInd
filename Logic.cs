using System.Collections.Generic;
using System;
using System.Linq;
using Pastel;
using System.Drawing;

namespace MasterMind
{
	public class Logic
	{
		public bool InputStringValidation(bool isGuessValid, List<string> guess, string colorOptions)
		{
			if( guess.Count == 0)
			{
				Console.WriteLine(" \n	Invalid guess input! \n 	Please choose from the given color input options. \n".Pastel(Color.DarkRed));
				return isGuessValid = false;
			}
			for ( var i = 0; i < guess.Count; i++)
			{
			/* 	if ( guess[i] == "S")
					return isGuessValid = true; */
				if ( guess[i].Split().Any(x => !colorOptions.Contains(x)))
				{
					guess[i] = "";
					Console.WriteLine(" \n	Invalid guess input! \n 	Please choose from the given color input options. \n".Pastel(Color.DarkRed));
					return isGuessValid = false;
				}
			}
			return isGuessValid = true;
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
		public bool GuessCounterCheck(int guessCounter, bool isGuessValid, string solution, string coloredSolution) 
		{
			if (guessCounter < 9 && isGuessValid) return isGuessValid = true;
			if (guessCounter >= 9)
			{
				Console.WriteLine("\n" + "	Your've ran out of tryes!" + "\n".Pastel(Color.DarkRed));
				guessCounter = 0;
				Console.WriteLine("\n" + "	SOLUTION : ".Pastel(Color.LightGoldenrodYellow) + coloredSolution + "\n");
				return isGuessValid = false;
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
			bool isGuessValid) 
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
				return isGuessValid = false;
			}
				return isGuessValid = true;
		}
	}
}

	