using System;
using System.Collections.Generic;
using System.Drawing;
using Pastel;

namespace MasterMind
{
	class Program
	{
		static string guess = new string("");
    static string solution = new string("");
		static string coloredSolution = new string("");
    static string colorOptions = new string("");
		static bool tryChecker = true;
		static bool validGuess = true;
		static bool autoSolverRequired;
		static int guessCounter = -1;
		static int whiteDot = 0;
		static int blackDot = 0;
		static List<string> convertedGuess = new List<string>();
		static List<List<string>> memory = new List<List<string>>();
		static List<List<string>> hintList = new List<List<string>>();
		static void Main(string[] args)
		{
			TxtParser.TxtParserFunction();
			Boards.DrawBoard(memory, guessCounter, hintList);

			colorOptions = Convert.EnumConverter(colorOptions);
			solution = Generate.GenerateSolutionList(colorOptions);
			coloredSolution = Generate.printableSolution(solution);
			while (tryChecker) 
			{
				Console.WriteLine( 
				"\n	Color Input Options:"
				+ "	B".Pastel(Color.Blue)
				+ "	C".Pastel(Color.Cyan)
				+ "	R".Pastel(Color.Red)
				+ "	G".Pastel(Color.Green)
				+ "	Y".Pastel(Color.Yellow)
				+ "	W".Pastel(Color.WhiteSmoke)
				+ "	P".Pastel(Color.BlueViolet)
				+ "\n");

				Console.WriteLine("\nGUESS: \n ");
				guess = Console.ReadLine();
				convertedGuess = Convert.GuessStringConverter(guess, colorOptions, guessCounter);
				// autoSolverRequired = Logic.AutoSolverInitialised(autoSolverRequired, convertedGuess);
				validGuess = Logic.InputStringValidation(validGuess, convertedGuess, colorOptions);
				if(validGuess)
				{
				/* 	if (autoSolverRequired)
					{
						guess = AutoSolver.GenerateAutoGuess(colorOptions);
						convertedGuess = Convert.GuessStringConverter(guess, colorOptions, guessCounter);
					} */
					guessCounter++;
					memory.Insert(guessCounter, convertedGuess);

					tryChecker = Logic.CheckGuessAgainstSolution(
						convertedGuess,
						guessCounter,
						blackDot,
						whiteDot,
						hintList,
						solution,
						coloredSolution,
						tryChecker);

					Boards.DrawBoard(memory, guessCounter, hintList);

					tryChecker = Logic.GuessCounterCheck(guessCounter, tryChecker, solution, coloredSolution);
				}
			}
		}
	}
}