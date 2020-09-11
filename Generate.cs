using System;
namespace MasterMind
{
  public static class Generate
  {
    static Random random = new Random();
    public static string checkableSolution = new string("");
    public static string GenerateSolutionList() 
		{
			Console.WriteLine(Convert.solution + " soltuion");
			Shuffler[] solutionString = {Convert.solution};
			foreach ( var solution in solutionString) 
			{
				Console.WriteLine(solution.Shuffled);
				checkableSolution = solution.Shuffled.Substring(0, 4);
			}
			return checkableSolution;
		}
	}
}