/* using System.Collections.Generic;
using System;
using System.Linq;
using Pastel;
using System.Drawing;

namespace MasterMind
{
  public static class AutoSolver
  {
		static string starterAutoGuess = new string("");
    public static string GenerateAutoGuess(string colorOptions) 
		{
			Shuffler[] solutionString = {colorOptions};
			foreach ( var color in solutionString) { starterAutoGuess = color.Shuffled.Substring(0, 4); }
			return starterAutoGuess;
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
} */