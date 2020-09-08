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

			while (tryChecker) {
				drawBoard.DrawBoard();
				Console.WriteLine("GUESS: ");
				var	input = Console.ReadLine();
				input.GetEnumerator();
				Console.WriteLine(input);
				//guess.AddRange(((IEnumerable) input).Cast<string>());
			}


		}
	}
}