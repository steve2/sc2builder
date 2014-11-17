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
            string fullPath = Path.Combine(AppPath.GetBuilds(), toWrite.Filepath);
            StreamWriter filewriter = new StreamWriter(fullPath);

            filewriter.WriteLine(toWrite.Name);
            filewriter.WriteLine(toWrite.Race + "-" + toWrite.Versus);

            filewriter.Close();
            return true;
        }
    }
}
