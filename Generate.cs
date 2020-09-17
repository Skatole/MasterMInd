using System;
namespace MasterMind
{
  public static class Generate
  {
    static Random random = new Random();
    public static string checkableSolution = new string("");
    public static string GenerateSolutionList(string solution) 
		{
			Shuffler[] solutionString = {solution};
			foreach ( var sol in solutionString) 
			{
				checkableSolution = sol.Shuffled.Substring(0, 4);
			}
			return checkableSolution;
		}
	}
}