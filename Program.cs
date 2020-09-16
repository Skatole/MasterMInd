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
		static void Main(string[] args)
		{
			Boards.DrawBoard(
				memory,
				guessCounter,
				blackDot,
				whiteDot,
				hintList);
			solution = Convert.CheckAndConvert(solution);
			solution = Generate.GenerateSolutionList(solution);
			while (tryChecker) 
			{
				guessCounter++;
				Logic.GuessCounterCheck(guessCounter, tryChecker);

				Console.WriteLine(" \n GUESS: \n ");
				guess = Console.ReadLine();

				string convertedGuess = Convert.stringEditor(guess);
				Logic.CheckGuessAgainstSolution(
					convertedGuess,
					guessCounter,
					blackDot,
					whiteDot,
					hintList,
					solution);

				List<string> subMemoryList = new List<string>();
				subMemoryList.Add(convertedGuess);
				memory.Insert(guessCounter, subMemoryList);

				Boards.DrawBoard(
					memory,
					guessCounter,
					blackDot,
					whiteDot,
					hintList);
			}
		}
	}
}