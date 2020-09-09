using System.Collections.Generic;
using System;
using System.Linq;

namespace MasterMind
{
	public static class Logic
	{
		static Random random = new Random();
		static List<string> solution = new List<string>();
		static List<string> shuffledSolution = new List<string>();
		static List<string>checkableSolution = new List<string>();
		static string concat;
		public static List<string> generateSolutionList() 
		{
			var colorValue = Enum.GetNames(typeof (Color)).ToList<string>();
			foreach ( var i in colorValue) 
			{
				if (i.SequenceEqual("Blue")) 
				{
					solution.Add("B");
				}
				if (i.SequenceEqual("Black")) 
				{
					solution.Add("b");
				}
				if (i.SequenceEqual("Red")) 
				{
					solution.Add("R");
				}
				if (i.SequenceEqual("Green")) 
				{
					solution.Add("G");
				}
				if (i.SequenceEqual("Yellow")) 
				{
					solution.Add("Y");
				}
				if (i.SequenceEqual("White")) 
				{
					solution.Add("W");
				}
				if (i.SequenceEqual("Purple")) 
				{
					solution.Add("P");
				}
			}
			foreach ( var s in solution)
			{
				shuffledSolution.Insert(random.Next(0, shuffledSolution.Count + 1), s);
				concat = String.Join(", ", shuffledSolution);
				
			}
			string cutConcat = concat.Substring(0, 10);
			Console.WriteLine(cutConcat);
			checkableSolution = cutConcat.Split(",").ToList();
			return checkableSolution;
		}
		public static bool checkGuessAgainstSolution(	string guessInput) 
		{	
			List<string> guessInputList = guessInput.Split(", ").ToList();
			var result =  checkableSolution.FindAll( r => r.Equals(guessInputList));
			//WIN checking
			if (result.Count == 4) {
				Console.WriteLine("WIN");
				Console.Clear();
				return true;
			} 
			// BLACK and WHITE dot determination ==> HINTS:
			for ( var i = 0; i < checkableSolution.Count(); i++) {
				for ( var j = 0; j < guessInputList.Count(); j++) {
					if (result.Count > 0 && result.Count != 4) {
						//WHITE dot for not being in the right place

						if ( i == j ) {
							// BLACK dot for beeing in the right place with the right color
						}
					} 
				}
			}
			if (result.Count == 0) {
				//Game continues no dots are being placed 
				//also increment the guessCouter var. by one
			}
			return false; 
		}	
	}
} 	