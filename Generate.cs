using System.Collections.Generic;
using System;
using System.Linq;

namespace MasterMind
{
  public static class Generate
  {
    static Random random = new Random();
    public static string checkableSolution = new string("");
    public static string generateSolutionList() 
		{
			List<string> solutionList = new List<string>();
    	List<string> shuffledSolution = new List<string>();
    	string concat = new string("");

			solutionList = Convert.solution.Split("").ToList();
			foreach ( var s in solutionList)
			{
				shuffledSolution.Insert(random.Next(0, shuffledSolution.Count + 1), s);
				concat = String.Join("", shuffledSolution);
				concat.Replace(",","");
				concat.Replace(" ","");
			}
		string cutConcat = concat.Substring(0, 4);
		checkableSolution = cutConcat;
		return checkableSolution;
		}
  }
}