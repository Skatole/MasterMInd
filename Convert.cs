using System.Collections.Generic;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MasterMind
{
  public static class Convert
  {
    public static string stringEditor(string guess)
    {
			string replacedGuess = Regex.Replace(guess, @"[^0-9a-zA-Z]+", "").ToUpper();
			if ( replacedGuess.Length > 4)
			{
     		replacedGuess = replacedGuess.Substring(0, 4);
				Console.WriteLine("Only Enter 4 characters!");
				
			}
			if (replacedGuess.Length < 4)
			{
				replacedGuess = replacedGuess.Insert(replacedGuess.Length, "    ").Substring(0, 4);
				Console.WriteLine("Please enter 4 character!");

			}
			return replacedGuess;
		} 
		public static string CheckAndConvert( string solution )
    {
			List<string> solutionList = new List<string>();
			var colorValue = Enum.GetNames(typeof (Color)).ToList<string>();
			foreach ( var i in colorValue) 
			{
				if (i.SequenceEqual("Blue")) 
				{
					solutionList.Add("B");
				}
				if (i.SequenceEqual("Cyan")) 
				{
					solutionList.Add("C");
				}
				if (i.SequenceEqual("Red")) 
				{
					solutionList.Add("R");
				}
				if (i.SequenceEqual("Green")) 
				{
					solutionList.Add("G");
				}
				if (i.SequenceEqual("Yellow")) 
				{
					solutionList.Add("Y");
				}
				if (i.SequenceEqual("White")) 
				{
					solutionList.Add("W");
				}
				if (i.SequenceEqual("Purple")) 
				{
					solutionList.Add("P");
				}
			}
			solution = string.Join("", solutionList).ToString();
			return solution;
		}
  }
}