using System;
using System.Collections.Generic;


namespace MasterMind
{
	class Program
	{
		public static string guess = new string("");
    public static string solution = new string("");
		public static bool tryChecker = true;
		public static int whiteDot = 0;
		public static int guessCounter = -1;
		public static int blackDot = 0;
		public static List<List<string>> hintList = new List<List<string>>();
		public static List<List<string>> memory = new List<List<string>>();
		public static List<string> convertedGuess = new List<string>();
		static void Main(string[] args)
		{
			TxtParser.TxtParserFunction();
			Boards.DrawBoard(
				memory,
				guessCounter,
				hintList);

			solution = Convert.CheckAndConvert(solution);
			solution = Generate.GenerateSolutionList(solution);
			while (tryChecker) 
			{
				Console.WriteLine( "\n" + "		 Color Input Options: B, C, R; G; Y; W; P;" + "\n");
				Console.WriteLine(" \n 		GUESS: \n ");
				guess = Console.ReadLine();
				guessCounter++;
				convertedGuess = Convert.stringEditor(guess);
				memory.Insert(guessCounter, convertedGuess);

				tryChecker = Logic.CheckGuessAgainstSolution(
					convertedGuess,
					guessCounter,
					blackDot,
					whiteDot,
					hintList,
					solution);

				Boards.DrawBoard(
					memory,
					guessCounter,
					hintList);

				tryChecker = Logic.GuessCounterCheck(guessCounter, tryChecker, solution);
			}
		}
	}
}