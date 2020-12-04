using System;
using System.Collections.Generic;
using Pastel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

namespace MasterMind
{
	public class Variables
	{
		private string _guess = new string("");
		public string guess 
		{
			get { return _guess; }
			set
			{
				_guess = value;
				InputStringValidation();
				GuessToPecek();
				// saveToMemory();
			}			 
		}
		private PecekColor[] _lastTippPecek = new PecekColor[_columns];
		// public PecekColor[] lastTippPecek { get { return lastTippPecek; }}
		private PecekColor[] _solution = new PecekColor[_columns];
		// { PecekColor.White, PecekColor.Purple, PecekColor.White, PecekColor.Purple};
		public PecekColor[] solution
		{
			get { return _solution; }
			set { _solution = value; }
		}
		private string[] _inputOptions = new string[10]
		{
			"B", "C", "R", "G", "Y", "W", "P", "S", "?", "L"
		};
		private bool _isGuessValid;
		public bool isGuessValid { get { return _isGuessValid; } }
		private bool _isAutoSolverRequired;
		public bool isAutoSolverRequired{ get { return _isAutoSolverRequired; } set { _isAutoSolverRequired = value; } }
		private bool _isTryValid = true;
		public bool isTryValid 
		{
			get { return _isTryValid; } 
			set 
			{
				 _isTryValid = value;
				 if (_isTryValid == false)
				{
					_isGuessValid = false;
				}
				 
			}
		}
		private int _guessCounter = 0;
		public int guessCounter
		{
			get { return _guessCounter; }
			set
			{
				_guessCounter = value;
			}
		}
		private int _whiteDot = -1;
		public int whiteDot
		{
			get { return _whiteDot; }
			set { _whiteDot = value; }		
		}
		private int _blackDot = 0;
		public int blackDot
		{
			get { return _blackDot; }
			set	{ _blackDot = value; }
		}
		private static int _columns = 4;
		public int columns { get { return _columns; } set { _columns = value; } }
		private static int _rows = 10;
		public int rows {	get { return _rows; } }
		private List<string> _replacedGuessList = new List<string>();
		private PecekColor[][] _guessMemory = new PecekColor[_rows][];
		public PecekColor[][] guessMemory
		{
			get { return _guessMemory; }
			set 
			{
				_guessMemory = value;
			}
		}
		private PecekColor[][] _hintArr = new PecekColor[_rows][];	
		public  PecekColor[][] hintArr 
		{
			get { return _hintArr; }
			set 
{	_hintArr = value; }
		}
		private void GuessToPecek()
		{
				_guessMemory[_guessCounter] = new PecekColor[_columns];
			for (int i = 0; i < _replacedGuessList.Count; i++)
			{
				switch (_replacedGuessList[i])
				{
						case "B": _guessMemory[_guessCounter][i] = PecekColor.Blue; break;
						case "C": _guessMemory[_guessCounter][i] = PecekColor.Cyan; break;
						case "R": _guessMemory[_guessCounter][i] = PecekColor.Red; break;
						case "G": _guessMemory[_guessCounter][i] = PecekColor.Green; break;
						case "Y": _guessMemory[_guessCounter][i] = PecekColor.Yellow; break;
						case "W": _guessMemory[_guessCounter][i] = PecekColor.White; break;
						case "P": _guessMemory[_guessCounter][i] = PecekColor.Purple; break;
						case "?": _guessMemory[_guessCounter][i] = PecekColor.None; break;
						case "S": _isAutoSolverRequired = true; break;
						case "L": foreach (var item in solution)
						{
							Console.WriteLine(item);
							_isGuessValid = false;
						}
						break;
						default: _guessMemory[_guessCounter][i] = PecekColor.None; break;
				}
			}

			_replacedGuessList.Clear();
		}
		private bool InputStringValidation()
		{
			// Convert the guess and add it to a easily editable List:
				string replacedGuess =  Regex.Replace(guess, @"[^0-9a-zA-Z]+", "").ToUpper();
				for ( var i = 0; i < replacedGuess.Length; i++ ) { _replacedGuessList.Add(replacedGuess[i].ToString()); }

			if( _replacedGuessList.Count == 0 )
			{
				Console.WriteLine( " \n	No guess Input! \n 	Please choose from the given color input options. \n".Pastel(Color.DarkRed) );
				return _isGuessValid = false;
			}
			if ( _replacedGuessList.Count > _columns )
			{
     		_replacedGuessList.RemoveRange( _columns, _replacedGuessList.Count - _columns );
				Console.WriteLine( "\n" + "Please	Only Enter 4 characters!".Pastel(Color.DarkRed) + "\n" );
			}
		 	if ( _replacedGuessList.Count < _columns )
			{
				Console.WriteLine( "\n" + "	Please enter 4 character!".Pastel(Color.DarkRed) + "\n" );
			}
			for ( var i = 0; i < _replacedGuessList.Count; i++ )
			{
				if ( _replacedGuessList[i].Split().Any(x => !_inputOptions.Contains(x)))
				{
					Console.WriteLine( " \n	Invalid guess input! \n 	Please choose from the given color input options. \n".Pastel(Color.DarkRed) );
					return _isGuessValid = false;
				}
			}
			
			return _isGuessValid = true;
		}
		
	}
}