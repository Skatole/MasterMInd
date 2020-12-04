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
			Variables variables = new Variables();

			TxtParser txtParser = new TxtParser();
			txtParser.TxtParserFunction();

			GenerateRandom generate = new GenerateRandom();
			generate.randomPecek( variables.solution, variables );

			Display display = new Display();
			// display.Print( variables );



			// Convert convert = new Convert();
			// variables.colorOptions = Convert.ColorConverter(	variables.colorOptions	);

			// Generate generate = new Generate();
			// generate.GenerateSolutionList( variables );
			// string coloredSolution = Generate.printableSolution( variables.solution );

			while (	variables.isTryValid )
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
				if (variables.isGuessValid && variables.isTryValid)
				{
					Logic logic = new Logic();
					logic.CheckGuessAgainstSolution( variables );
					display.Print( variables );
					Logic.GuessCounterCheck( variables );
				}

			}
		}
	}
}