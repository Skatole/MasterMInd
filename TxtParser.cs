using System.IO;
using System;


namespace MasterMind
{
  public static class TxtParser
  {
		public static FileInfo fi = new FileInfo("Welcome.txt");
    public static StreamReader parser = fi.OpenText();
		public static string line;
		public static void TxtParserFunction()
		{
			while ((line = parser.ReadLine()) != null) 
			{
   			string[] items = line.Split('\n');
   			string path = null;
   			foreach (string item in items) 
   			{
   			  path = item;
   			}
				Console.WriteLine(path);
			}
		}
  }
}