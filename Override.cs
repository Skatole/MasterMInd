using System.Collections.Generic;
using System;
using System.Linq;

namespace MasterMind
{
  public class Override
  {
  	public static void overrideBoard(string guess){}
	/* 	{
			if (guess.Any( item => Convert.solution.Contains(item)))
			{
				Logic.guessCounterCheck();
				foreach ( var g in guess)
				{
					for ( var i = 0; i < Boards.guessBoard.Length; i++)
					{
						Boards.guessBoard[Logic.guessCounter] = new string[Boards.columns - 3];
						for ( var j = 0; j < Boards.guessBoard[i].Length; j++)
						{
							Boards.guessBoard[Logic.guessCounter][j] = g; 
						}
					}
				}
			}
			else
			{
				Console.WriteLine("im in the else of override");
			}
		} */
	}
}		