using System;
using System.Collections.Generic;

namespace MasterMind
{
	class Program
	{
		public static string guess = new string("");
		static void Main(string[] args)
		{
			Boards.DrawBoard();
			Convert.checkAndConvert();
			Generate.generateSolutionList();
			while (Logic.tryChecker) 
			{
				Console.WriteLine("GUESS: ");
				guess = Console.ReadLine();
				Logic.checkGuessAgainstSolution(guess);
			}
		}
	}
}