using System.Collections.Generic;
using System;
using System.Linq;

namespace MasterMind
{
	public static class Logic
	{

		public static bool GuessCounterCheck(int guessCounter, bool tryChecker, string solution) 
		{
			if (guessCounter <= 9 && tryChecker) 
			{
				return Program.tryChecker = true;
			}
			if (guessCounter >= 10)
			{
				Console.WriteLine(guessCounter);
				Console.WriteLine("\n" + "Your've ran out of tryes!" + "\n");
				guessCounter = 0;
				Console.WriteLine("SOLUTION : " + solution);
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
			string solution) 
		{
			List<string> solutionClone = solution.Select(s => s.ToString()).ToList();
			List<string> hintSubList = new List<string>();
			
			Console.WriteLine(solutionClone.Count);
			Console.WriteLine(solution);

			// BLACK and WHITE dot determination ==> HINTS:
			for (int i = 0; i < solutionClone.Count; i++)
			{
				Console.WriteLine((solutionClone.Contains(convGuess[i].ToString()).ToString()) + " for elott");

				// convGuess.Count() == solutionClone.Count()) && !convGuess.Except(solutionClone).Any()
				hintSubList.Add("o");
				if (solutionClone[i] == convGuess[i])
				{
					blackDot++;
					hintSubList.Insert(i, "B");
					solutionClone[i] = "";
				}
				else if  (solutionClone.Contains(convGuess[i].ToString()))
				{
					Console.WriteLine((solutionClone.Contains(convGuess[i].ToString()).ToString()) + i.ToString() + " ifben");
					whiteDot++;
					hintSubList.Insert(i, "W");
					solutionClone[i] = "";

				}
			}
			if ( hintSubList.Count > 4)
			{
				hintSubList.RemoveRange(4, hintSubList.Count - 4);
			}
			hintList.Insert(guessCounter, hintSubList);
			Console.WriteLine(blackDot + " blackDots");
			Console.WriteLine(whiteDot + " whiteDots");
			// WIN determination
			if (convGuess.SequenceEqual(solutionClone) || blackDot == 4)
			{
				Console.WriteLine("WIN");
				Console.WriteLine("SOLUTION : " + solution);
				// blackDot = 4;
				// for ( int i = 0; i < 4; i++) hintSubList.Insert(i, "B");
				return Program.tryChecker = false;
			}
			else
			{
				return Program.tryChecker;
			}
		}
	}
}