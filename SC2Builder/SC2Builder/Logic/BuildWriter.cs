using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SC2Builder.Logic
{
	class BuildWriter
	{
		public static bool WriteToFile(Build toWrite)
		{
			string fullPath = Path.Combine(AppPath.GetBuilds(), Path.GetFileName(toWrite.Filepath));
			StreamWriter filewriter = new StreamWriter(fullPath);

			Console.WriteLine(fullPath);

			filewriter.WriteLine(toWrite.Name);
			filewriter.WriteLine(toWrite.Race + "-" + toWrite.Versus);
			foreach (Step S in toWrite.Steps)
			{
				filewriter.WriteLine(S.RawString());
			}
			filewriter.Close();
			return true;
		}
	}
}
