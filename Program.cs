using System;

namespace MasterMind
{
	class Program
	{
		public static string guess = new string("");
		public static bool tryChecker = true;
		public static int guessCounter = 0;
		static void Main(string[] args)
		{
			Boards.DrawBoard();
			Convert.CheckAndConvert();
			Generate.GenerateSolutionList();
			while (tryChecker) 
			{
				Console.WriteLine(" \n GUESS: \n ");
				guess = Console.ReadLine();
				Logic.GuessCounterCheck();
				Logic.CheckGuessAgainstSolution(guess);
			}
		}
	}
}