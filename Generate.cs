using System;
namespace MasterMind
{
  public static class Generate
  {
    static Random random = new Random();
    public static string checkableSolution = new string("");
    public static string GenerateSolutionList(string solution) 
		{
			Console.WriteLine(solution + " soltuion");
			Shuffler[] solutionString = {solution};
			foreach ( var sol in solutionString) 
			{
				Console.WriteLine(sol.Shuffled);
				checkableSolution = sol.Shuffled.Substring(0, 4);
			}
			return checkableSolution;
		}
	}
}