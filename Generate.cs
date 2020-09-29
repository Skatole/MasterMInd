using System;
using Pastel;
using System.Drawing;

namespace MasterMind
{
  public class Generate
  {
    string checkableSolution = new string("");
    public string GenerateSolutionList(string solution) 
		{
			Variables variables = new Variables();
			Shuffler[] solutionString = {solution};
			foreach ( var sol in solutionString) { checkableSolution = sol.Shuffled.Substring(0, variables.columns); }
			return checkableSolution;
		}

		public static string printableSolution(string solution)
		{
			string solutionColor = new string("");
			for ( var i = 0; i < solution.Length; i++)
			{
				switch(solution[i].ToString())
				{
					case "B": solutionColor += "	o".Pastel(Color.Blue); break;
					case "C": solutionColor += "	o".Pastel(Color.Cyan); break;
					case "R": solutionColor += "	o".Pastel(Color.Red); break;
					case "G": solutionColor += "	o".Pastel(Color.Green); break;
					case "Y": solutionColor += "	o".Pastel(Color.Yellow); break;
					case "W": solutionColor += "	o".Pastel(Color.White); break;
					case "P": solutionColor += "	o".Pastel(Color.Purple); break;
				}
			}
			return solutionColor;
		}
	}
}