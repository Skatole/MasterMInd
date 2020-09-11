using System.Collections.Generic;
using System;
using System.Linq;

namespace MasterMind
{
	public static class Logic
	{
		public static bool GuessCounterCheck() 
		{
			if (Program.guessCounter <= 2 && Program.guessCounter != 1) 
			{
				return Program.tryChecker = true;
			}
			if (Program.guessCounter >= 3)
			{
				Console.WriteLine();
				Console.WriteLine("Your've ran out of tryes!");
				Program.guessCounter = 0;
				return Program.tryChecker = false;
			}
			return false; 
		}
		public static bool CheckGuessAgainstSolution(string guessString) 
		{
			string convGuess = Convert.stringConverter(guessString);
			string solution = Generate.checkableSolution;
			char[] solutionClone = solution.ToCharArray();
			int whiteDot = 0;
			int blackDot = 0;

			// Console.WriteLine(solution + " CICA");

			//WIN checking
				if (convGuess == solution)
				{
					Console.WriteLine("WIN");
					return Program.tryChecker = false;
				}
				// BLACK and WHITE dot determination ==> HINTS:
				for (int i = 0; i < solutionClone.Length; i++)
				{
					if (solutionClone[i] == convGuess[i])
					{
						blackDot++;
						solutionClone[i] = ' ';
					}
					if (solutionClone.Contains(convGuess[i]))
					{
						whiteDot++;
						solutionClone[i] = ' ';

					}
				}
			Console.WriteLine(blackDot + " blackDots");
			Console.WriteLine(whiteDot + " whiteDots");
			Boards.OverrideBoard(convGuess, Program.guessCounter, blackDot, whiteDot);
			return Program.tryChecker;
		}
	}
}