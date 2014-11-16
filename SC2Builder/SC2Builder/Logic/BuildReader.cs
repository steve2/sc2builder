using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SC2Builder
{
    class BuildReader
    {
        public static Build ReadFromFile(string filename)
        {
            Step buildStep;
            List<Step> buildSteps;
            string line;
            string[] lineSplit;
            string buildName;
            string buildMatchup;

            System.IO.StreamReader filereader = new System.IO.StreamReader(filename);

            buildName = filereader.ReadLine();
            buildMatchup = filereader.ReadLine();

            if (buildName == null || buildMatchup == null)
            {
                return null;
            }

            buildSteps = new List<Step>();
            while ((line = filereader.ReadLine()) != null)
            {
                lineSplit = line.Split('-');

                buildStep = new Step(lineSplit[0], lineSplit[1]);
                buildSteps.Add(buildStep);
            }
            return new Build(buildName, buildMatchup, buildSteps);
        }
    }
}
