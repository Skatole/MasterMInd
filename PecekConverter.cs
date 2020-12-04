using System;
using System.Collections.Generic;
using System.Drawing;
using Pastel;

namespace MasterMind
{
	public class PecekConverter
	{
		private List<string> allTheColorInOneRow = new List<string>();
		public List<string> PecekToColor( Variables variables, PecekColor[] pecekList )
		{
			for (var j = 0; j < pecekList.Length; j++)
			{
				switch (pecekList[j])
				{
					case PecekColor.Blue: allTheColorInOneRow.Add("o".Pastel(Color.Blue)); break;
					case PecekColor.Cyan: allTheColorInOneRow.Add("o".Pastel(Color.Cyan)); break;
					case PecekColor.Red: allTheColorInOneRow.Add("o".Pastel(Color.Red)); break;
					case PecekColor.Green: allTheColorInOneRow.Add("o".Pastel(Color.Green)); break;
					case PecekColor.Yellow: allTheColorInOneRow.Add("o".Pastel(Color.Yellow)); break;
					case PecekColor.White: allTheColorInOneRow.Add("o".Pastel(Color.White)); break;
					case PecekColor.Purple: allTheColorInOneRow.Add("o".Pastel(Color.Purple)); break;
					case PecekColor.Black: allTheColorInOneRow.Add("o".Pastel(Color.Black)); break;
					case PecekColor.None: allTheColorInOneRow.Add("o".Pastel(Color.DarkSlateGray)); break;
				}
			}
			return allTheColorInOneRow;
		}
	}
}