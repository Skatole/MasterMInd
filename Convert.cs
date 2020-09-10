using System.Collections.Generic;
using System;
using System.Linq;

namespace MasterMind
{
  public static class Convert
  {
    public static string guessInput = new string("");
    public static string solution = new string("");
    public static string guessSubstring = new string("");
    public static string stringConverter(string guess)
    {
			string  replacedGuess = guess.ToUpper().Replace(" ", "").Replace(",","");
			if ( replacedGuess.Length > 4)
			{
     		guessSubstring = replacedGuess.Remove(4);
				Console.WriteLine("Only Enter 4 characters!");
			}
			guessInput = string.Join("", replacedGuess);
			Override.overrideBoard(guessInput);
			return guessInput;
		} 
		public static string checkAndConvert()
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
					solutionList.Add("F");
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