using System;
using System.Collections.Generic;
using System.Drawing;
using Pastel;

namespace MasterMind
{
	public class Program
	{
		private static void Main(string[] args)
		{
			TxtParser txtParser = new TxtParser();
			txtParser.TxtParserFunction();

			Variables variables = new Variables();

			Boards boards = new Boards();
			boards.DrawBoard(	variables.guessMemory,
												variables.guessCounter,
												variables.hintList,
												variables.rows,
												variables.columns);

			Convert convert = new Convert();
			variables.colorOptions = Convert.ColorConverter(	variables.colorOptions	);

			Generate generate = new Generate();
			variables.solution = generate.GenerateSolutionList(	variables.colorOptions	);
			string coloredSolution = Generate.printableSolution(	variables.solution	);

			while (	variables.isTryValid	)
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
				variables.guess = Console.ReadLine();
				variables.convertedGuess = convert.GuessStringConverter(	variables.guess,
																																	variables.colorOptions,
																																	variables.guessCounter	);

				Logic logic = new Logic();
				variables.isGuessValid = logic.InputStringValidation(	variables.isGuessValid,
																															variables.convertedGuess,
																															variables.colorOptions	);
				if (variables.isGuessValid)
				{
					variables.guessCounter++;
					variables.guessMemory.Insert(	variables.guessCounter, variables.convertedGuess	);
					variables.isTryValid = Logic.CheckGuessAgainstSolution(	variables.convertedGuess,
																																	variables.guessCounter,
																																	variables.blackDot,
																																	variables.whiteDot,
																																	variables.hintList,
																																	variables.solution,
																																	coloredSolution,
																																	variables.isGuessValid	);
					boards.DrawBoard(	variables.guessMemory,
														variables.guessCounter,
														variables.hintList,
														variables.rows,
														variables.columns	);
					variables.isTryValid = logic.GuessCounterCheck(	variables.guessCounter,
																													variables.isTryValid,
																													variables.solution,
																													coloredSolution	);
				}
			}
		}
	}
}