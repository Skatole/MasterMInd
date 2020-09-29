using System.Collections.Generic;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Drawing;
using Pastel;

namespace MasterMind
{
  public class Convert
  {
    public List<string> GuessStringConverter(string guess, string colorOptions, int guessCounter)
    {
			List<string> replacedGuessList = new List<string>();
			string replacedGuess =  Regex.Replace(guess, @"[^0-9a-zA-Z]+", "").ToUpper();
			for (var i = 0; i < replacedGuess.Length; i++) {replacedGuessList.Add(replacedGuess[i].ToString());}
			if (replacedGuessList.Count > 4)
			{
     		replacedGuessList.RemoveRange(4, replacedGuessList.Count - 4);
				Console.WriteLine("\n" + "	Only Enter 4 characters!".Pastel(Color.DarkRed) + "\n");
			}
			 else if (replacedGuessList.Count < 4 && replacedGuessList.Count != 0 && !replacedGuessList.Contains("S"))
			{
				for ( var i = 0; i < 4; i++) {replacedGuessList.Insert(replacedGuessList.Count, " ");}
     		replacedGuessList.RemoveRange(4, replacedGuessList.Count - 4);
				Console.WriteLine("\n" + "	Please enter 4 character!".Pastel(Color.DarkRed) + "\n");
			}
			return replacedGuessList;
		} 
		public static string ColorConverter( string colorOptions)
    {
			List<string> optionList = new List<string>();
			var colorValue = Enum.GetNames(typeof (PecekColor)).ToList<string>();
			foreach ( var i in colorValue) 
			{
				switch(i)
				{
					case "Blue": optionList.Add("B"); break;
					case "Cyan": optionList.Add("C"); break;
					case "Red": optionList.Add("R"); break;
					case "Green": optionList.Add("G"); break;
					case "Yellow": optionList.Add("Y"); break;
					case "White": optionList.Add("W"); break;
					case "Purple": optionList.Add("P"); break;
					default: optionList.Add(""); break;
				}
			}
			colorOptions = string.Join("", optionList).ToString();
			return colorOptions;
		}
  }
}