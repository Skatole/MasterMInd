using System.Collections.Generic;
using System;
using System.Linq;

namespace MasterMind
{
	public static class Logic
	{

		public static bool GuessCounterCheck(int guessCounter) 
		{
			if (guessCounter <= 9) 
			{
				Console.WriteLine(guessCounter + " in guesscheck");
				return Program.tryChecker = true;
			}
			if (guessCounter >= 10)
			{
				Console.WriteLine(guessCounter);
				Console.WriteLine("\n" + "Your've ran out of tryes!" + "\n");
				guessCounter = 0;
				return Program.tryChecker = false;
			}
			return false; 
		}
		public static bool CheckGuessAgainstSolution(string convGuess, int blackDot, int whiteDot) 
		{
			
			string solution = Generate.checkableSolution;
			char[] solutionClone = solution.ToCharArray();
		
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
					else
					{
						return Program.tryChecker;
					}
				}
			Console.WriteLine(blackDot + " blackDots");
			Console.WriteLine(whiteDot + " whiteDots");
			return Program.tryChecker;
		}
	}
}