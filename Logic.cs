using System.Collections.Generic;
using System;
using System.Linq;




namespace MasterMind
{
	public class Logic
	{
		public static bool guessCheck(	List<string> guessedSolution, List<string> generatedSolution) {

			var result =  generatedSolution.FindAll( r => r.Equals(guessedSolution));
			//WIN checking
			if (result.Count == 4) {

				Console.WriteLine("WIN");
				Console.Clear();
				return true;
			} 
			// BLACK and WHITE dot determination ==> HINTS:
			for ( var i = 0; i < generatedSolution.Count(); i++) {
				for ( var j = 0; j < guessedSolution.Count(); j++) {
					if (result.Count > 0 && result.Count != 4) {
						//WHITE dot for not being in the right place
						
						if ( i == j ) {
							// BLACK dot for beeing in the right place with the right color
						}
					} 
				}
			}


			return false; 
		}	
	}
}