using System.Collections.Generic;
using System;
using System.Linq;

namespace MasterMind
{
	public static class Logic
	{
		public static bool tryChecker = true;
		public static int guessCounter = 0;
		public static bool guessCounterCheck() 
		{
			guessCounter++;
			if (guessCounter <= 10) return tryChecker = true;
			else return tryChecker = false;
		}
		public static bool checkGuessAgainstSolution(string guessString) 
		{
			
			string convGuess = Convert.stringConverter(guessString);
			Console.WriteLine($"conv: {convGuess} guess: {guessString}");
			string solution = Generate.checkableSolution;
			char[] solutionClone = solution.ToCharArray();
			int whiteDot = 0;
			int blackDot = 0;

			Console.WriteLine(solution + " CICA");
			//WIN checking
			if (convGuess == solution)
			{
				Console.WriteLine("WIN");
				return tryChecker = false;
			}
			// BLACK and WHITE dot determination ==> HINTS:
			for (int i = 0; i < solutionClone.Length; i++)
			{
				if (solutionClone[i] == convGuess[i])
				{
					blackDot++;
					solutionClone[i] = ' ';
					Console.WriteLine(blackDot + " blackDots");
				}
				// string solutionCloneString = string.Join("", solutionClone);
				// int index = solutionCloneString.(guessString[i]);
				if (solutionClone.Contains(convGuess[i]))
				{
					whiteDot++;
					solutionClone[i] = ' ';
					Console.WriteLine(whiteDot + " whiteDots");
					
				}
			}
			return tryChecker;
		}	
	}
} 	