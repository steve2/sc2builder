using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC2Builder
{
	class Build
	{
		private string sName;
		private string sRace;
		private string sVersus;
		private string sFilename;
		private List<Step> steps;

		public Build(string name, string matchup, List<Step> steps, string filename)
		{
			string[] split = matchup.Split('-');

			this.sName = name;
			this.sRace = split[0];
			this.sVersus = split[1];
			this.sFilename = filename;
			this.steps = new List<Step>(steps);
		}

		public override bool Equals(object obj)
		{
			if (obj is Build)
			{
				Build B = (Build)obj;
				return this.sName.Equals(B.sName);
			}
			return false;
		}

		public bool Equals(string str)
		{
			return this.sName.Equals(str);
		}

		public string Filepath
		{
			get
			{
				return sFilename;
			}
		}

		public string Name
		{
			get
			{
				return sName;
			}
		}

		public string Race
		{
			get
			{
				return sRace;
			}
		}

		public string Versus
		{
			get
			{
				return sVersus;
			}
		}

		public List<Step> Steps
		{
			get
			{
				return steps;
			}
		}

		public override string ToString()
		{
			string result = this.sName + "\n" + this.sRace + " -vs- " + this.sVersus + "\n";
			foreach (Step S in this.steps)
			{
				result += S.ToString() + "\n";
			}
			return result;
		}
	}
}
