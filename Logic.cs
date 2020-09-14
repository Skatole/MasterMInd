using System.Collections.Generic;
using System;
using System.Linq;

namespace MasterMind
{
	public static class Logic
	{
		public static List<string> memory = new List<string>();
		public static int guessCounter = 0;
		public static bool GuessCounterCheck() 
		{
			if (guessCounter < 10) 
			{
			Console.WriteLine(guessCounter);

				guessCounter++;
				return Program.tryChecker = true;

			}
			if (guessCounter >= 10)
			{
			Console.WriteLine(guessCounter);

				Console.WriteLine();
				Console.WriteLine("Your've ran out of tryes!");
				guessCounter = 0;
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
			for ( int g = 0; g < convGuess.Length; g++)
			{
			memory.Add(convGuess[g].ToString());
			}
			Boards.OverrideBoard(memory, guessCounter, blackDot, whiteDot);
			return Program.tryChecker;
		}
	}
}