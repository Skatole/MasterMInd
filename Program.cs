using System;
using System.Collections.Generic;



namespace MasterMind
{
	class Program
	{
		static void Main(string[] args)
		{
			bool tryChecker = true;
			List<string> guess = new List<string>();
			Board.Boards drawBoard = new Board.Boards();
			drawBoard.DrawBoard();
			Logic.generateSolutionList();

			while (tryChecker) {
				Console.WriteLine("GUESS: ");
				string input = string.Join(", ", Console.ReadLine()).ToString();
				Logic.checkGuessAgainstSolution(input);
				
				
				Console.WriteLine(input);
				
			
				//guess.AddRange(((IEnumerable) input).Cast<string>());
			}


		}
	}
}