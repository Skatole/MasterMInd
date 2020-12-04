using System.Collections.Generic;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using Pastel;
using System.Drawing;

namespace MasterMind
{
	public class Logic
	{
		public static void GuessCounterCheck( Variables variables ) 
		{
			Console.WriteLine(variables.isGuessValid +  " isguessvalid");
			if (variables.guessCounter < variables.rows && variables.isGuessValid)
			{
				variables.guessCounter++;
				variables.isTryValid = true;
			} 
			if (variables.guessCounter >= variables.rows)
			{
				// variables.guessCounter = 0;
				variables.isTryValid = false;
			}
		}
		public bool CheckGuessAgainstSolution( Variables variables ) 
		{
			PecekColor[] solutionClone = (PecekColor[]) variables.solution.Clone();
			PecekColor[] guessMemoryClone = (PecekColor[]) variables.guessMemory[variables.guessCounter].Clone();

			variables.hintArr[variables.guessCounter] = new PecekColor[variables.columns];
			// BLACK and WHITE dot determination ==> HINTS:
			
			for (int i = 0; i < guessMemoryClone.Length; i++)
			{
				if (solutionClone[i] == guessMemoryClone[i])
				{
					variables.hintArr[variables.guessCounter][i] = PecekColor.Black;
					solutionClone[i] = PecekColor.SolutionEmpty;
					guessMemoryClone[i] = PecekColor.GuessEmpty;
				}
			}
			for (int j = 0; j < guessMemoryClone.Length; j++)
			{
				for (int k = 0; k < solutionClone.Length; k++)
				{
					if ( solutionClone[k] == guessMemoryClone[j] )
						{
							variables.hintArr[variables.guessCounter][j] = PecekColor.White;
							solutionClone[k] = PecekColor.SolutionEmpty;
							guessMemoryClone[j] = PecekColor.GuessEmpty;
						}
				}
			}

			// WIN determination
			if ( variables.guessMemory[variables.guessCounter].SequenceEqual(variables.solution))
			{
				return variables.isTryValid = false;
			}

				return variables.isTryValid;
		}

	}
}

	