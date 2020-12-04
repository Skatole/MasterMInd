using System;
using System.Linq;
using System.Collections.Generic;
using System.Timers;


namespace MasterMind
{
  public class GenerateRandom
  {
		private Random random = new Random( (int) DateTime.Now.Ticks );
		List<int> randomNumber = new List<int>();
    public void randomPecek( Variables variables )
		{
			for(int i = 1; i <= Enum.GetValues(typeof(PecekColor)).Length - 3; i++)
			{
				randomNumber.Add(random.Next(i, Enum.GetValues(typeof(PecekColor)).Length - 3));
			}
			for ( int j = 0; j < variables.columns; j++)
			{
				variables.solution[j] = (PecekColor) randomNumber[j];
			}


			
					// variables.solution.RemoveRange( variables.columns, variables.solution.Count - variables.columns);
					// foreach (var item in variables.solution)
					// {
					// 	Console.WriteLine(item + " solution ");
					// }
			// Shuffler shuffler = new Shuffler(variables.solution.ToString());

			// for ( int i = 0; i < variables.solution.Count; i++)
			// {
			// 	foreach (var item in shuffler.ToString())
			// 	{
			// 			variables.solution[i] = (PecekColor) ((int) item);
			// 			Console.WriteLine(variables.solution[i] + " solution after");
			// 	}	
			// }
			// variables.solution.RemoveRange(variables.columns, variables.solution.Count - variables.columns);


		}
  }
}