using System.Collections.Generic;
using System;
using System.Linq;

namespace MasterMind
{
	public static class Logic
	{

		public static bool GuessCounterCheck(int guessCounter, bool tryChecker) 
		{
			if (guessCounter <= 9) 
			{
				return Program.tryChecker = true;
			}
			if (guessCounter == 10)
			{
				Console.WriteLine(guessCounter);
				Console.WriteLine("\n" + "Your've ran out of tryes!" + "\n");
				guessCounter = 0;
				return Program.tryChecker = false;
			}
			return false; 
		}
		public static bool CheckGuessAgainstSolution(
			string convGuess,
			int guessCounter,
			int blackDot,
			int whiteDot,
			List<List<string>> hintList,
			string solution) 
		{
			List<string> solutionClone = solution.Select(c => c.ToString()).ToList();
			List<string> hintSubList = new List<string>();
		
			// WIN determination
			if (convGuess == solution)
			{
				Console.WriteLine("WIN");
				return Program.tryChecker = false;
			}

			// BLACK and WHITE dot determination ==> HINTS:
			for (int i = 0; i < solutionClone.Count; i++)
			{
				hintSubList.Add("o");
				if (solutionClone[i] == convGuess[i].ToString())
				{
					blackDot++;
					hintSubList.Insert(i, "B");
					solutionClone[i] = null;
				}
				if (solutionClone.Contains(convGuess[i].ToString()))
				{
					whiteDot++;
					hintSubList.Insert(i, "W");
					solutionClone[i] = null;
				}
			}
			if ( hintSubList.Count > 4)
			{
				hintSubList.RemoveRange(4, hintSubList.Count - 4);
			}
			hintList.Insert(guessCounter, hintSubList);
			Console.WriteLine(blackDot + " blackDots");
			Console.WriteLine(whiteDot + " whiteDots");
			Console.WriteLine(string.Join("", hintSubList).ToString());
			return Program.tryChecker;
		}
	}
}