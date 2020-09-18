using System;
using System.Text;
using System.Collections.Generic;

namespace MasterMind
{
	public class Shuffler
	{
		private string original;
		private StringBuilder shuffled;
		private int ignoredChars;
 
		public string Original
		{
			get { return original; }
		}
 
		public string Shuffled
		{
			get { return shuffled.ToString(); }
		}
 
		public int Ignored
		{
			get { return ignoredChars; }
		}
 
		private void Swap(int pos1, int pos2)
		{
			char temp = shuffled[pos1];
			shuffled[pos1] = shuffled[pos2];
			shuffled[pos2] = temp;
		}
		//If true, a swap is OK. 
		private bool TrySwap(int pos1, int pos2)
		{
			if (original[pos1] == shuffled[pos2] || original[pos2] == shuffled[pos1])
				return false;
			else
				return true;
		}
		public Shuffler(string word)
		{
			original = word;
			shuffled = new StringBuilder(word);
			Shuffle();
			DetectIgnores();
		}

		private void Shuffle()
		{
			int length = original.Length;
			int swaps;
			Random rand = new Random();
			List<int> used = new List<int>();
 
			for (int i = 0; i < length; i++)
			{
				swaps = 0;
				while(used.Count <= length - i)
				{
					int j = rand.Next(i, length - 1);
					if (original[i] != original[j] && TrySwap(i, j) && !used.Contains(j))
					{
						Swap(i, j);
						swaps++;
						break;
					}
					else
						used.Add(j);//blacklisting the index when swap didnt work thus it doesnt have to check every index again
				}
				if (swaps == 0)
				{
					for (int k = i; k >= 0; k--)
					{
						if (TrySwap(i, k))
							Swap(i, k);
					}
				}
				//clear the blacklist
				used.Clear();
			}
		}
 
		private void DetectIgnores()
		{
			int ignores = 0;
			for (int i = 0; i < original.Length; i++)
			{
				if (original[i] == shuffled[i])
					ignores++;
			}
 
			ignoredChars = ignores;
		}
 
		// for the conversion form string to Shuffler
		public static implicit operator Shuffler(string stringInput)
		{
			return new Shuffler(stringInput);
		}
	}
}