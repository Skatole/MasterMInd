using System.Collections.Generic;
using System;
using System.Linq;
using Pastel;
using System.Drawing;

namespace MasterMind
{
  public class AutoSolver
  {
		static string starter = new string("");
    private PecekColor[]  GenerateGuess( Variables variables) 
		{

		}

		public static string GenerateHintBasedSolution(int blackDot, int whiteDot)
		{
			if ( whiteDot > 0 || blackDot > 0)
			{
				for ( int i = 0; i < starterAutoGuess.Length/2; i++)
				{
					starterAutoGuess = starterAutoGuess[i].ToString();
				}
			}
			return starterAutoGuess;
		}
  }
} 