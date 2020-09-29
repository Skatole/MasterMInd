using System.IO;
using System;


namespace MasterMind
{
  public class TxtParser
  {
		public static FileInfo fi = new FileInfo("Welcome.txt");
    public StreamReader parser = fi.OpenText();
		public string line;
		public void TxtParserFunction()
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