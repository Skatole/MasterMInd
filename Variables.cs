using System;
using System.Collections.Generic;


namespace MasterMind
{
	public class Variables
	{
		public string guess = new string("");
		public string solution = new string("");
		public string colorOptions = new string("");
		public bool isGuessValid = true;
		public bool isAutoSolverRequired;
		public bool isTryValid = true;
		public int guessCounter = -1;
		public int whiteDot = 0;
		public int blackDot = 0;
		public int columns = 4;
		public int rows = 10;
		public List<string> convertedGuess = new List<string>();
		public List<List<string>> guessMemory = new List<List<string>>();
		public List<List<string>> hintList = new List<List<string>>();
	}
}