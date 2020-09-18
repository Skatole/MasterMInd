using System.Collections.Generic;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MasterMind
{
  public static class Convert
  {
    public static List<string> stringEditor(string guess)
    {
			List<string> replacedGuessList = new List<string>();
			string replacedGuess =  Regex.Replace(guess, @"[^0-9a-zA-Z]+", "").ToUpper();
			for (var i = 0; i < replacedGuess.Length; i++)
			{
				replacedGuessList.Add(replacedGuess[i].ToString());
			}

			if (  replacedGuessList.Count > 4)
			{
     		replacedGuessList.RemoveRange(4, replacedGuessList.Count - 4);
				Console.WriteLine("Only Enter 4 characters!");
				
			}
			if (replacedGuess.Length < 4)
			{
				for ( var i = 0; i < 4; i++)
				{
					replacedGuessList.Insert(replacedGuessList.Count, " ");
				}
     		replacedGuessList.RemoveRange(4, replacedGuessList.Count - 4);
				Console.WriteLine("Please enter 4 character!");

			}
			return replacedGuessList;
		} 
		public static string CheckAndConvert( string solution )
    {
			List<string> solutionList = new List<string>();
			var colorValue = Enum.GetNames(typeof (EnumColor)).ToList<string>();
			foreach ( var i in colorValue) 
			{
				switch(i)
				{
					case "Blue": solutionList.Add("B"); break;
					case "Cyan": solutionList.Add("C"); break;
					case "Red": solutionList.Add("R"); break;
					case "Green": solutionList.Add("G"); break;
					case "Yellow": solutionList.Add("Y"); break;
					case "White": solutionList.Add("W"); break;
					case "Purple": solutionList.Add("P"); break;
					default: solutionList.Add(""); break;
				}
			}
			solution = string.Join("", solutionList).ToString();
			return solution;
		}
  }
}