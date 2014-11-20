using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SC2Builder.Model;

namespace SC2Builder.Model
{
	class EditorContents
	{
		private string sName;
		private string sRace;
		private string sMatchup;
		private List<Step> stepList;

		public EditorContents(string name, string race, string matchup, string steps)
		{
			string[] splitNewlines;
			string[] splitDash;
			Step tempStep;

			this.sName = name.Trim();
			this.sRace = race.Trim();
			this.sMatchup = matchup.Trim();
			this.stepList = new List<Step>();

			splitNewlines = steps.Split('\n');
			foreach (string str in splitNewlines)
			{
				if (str != "" && str != null)
				{
					splitDash = str.Split('-');
					if (splitDash.Length == 2)
					{
						tempStep = new Step(splitDash[0], splitDash[1]);
						this.stepList.Add(tempStep);
					}
					else
					{
						this.stepList.Add(Step.ErrorStep);
					}
				}
			}
		}

		public bool ContentIsValid()
		{
			bool bNameCondition = (sName != null && !sName.Trim().Equals(""));
			bool bRaceCondition = (sRace.Equals("Terran") || sRace.Equals("Protoss") || sRace.Equals("Zerg"));
			bool bMatchCondition = (sMatchup.Equals("Terran") || sMatchup.Equals("Protoss") || sMatchup.Equals("Zerg"));
			bool bStepErrors = true;

			foreach (Step S in stepList)
				if (S.Equals(Step.ErrorStep))
					bStepErrors = false;

			return bNameCondition && bRaceCondition && bMatchCondition && bStepErrors;
		}

		public Build ToBuild()
		{
			return new Build(sName, sRace + "-" + sMatchup, stepList, sName + ".txt");
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

		public string Matchup
		{
			get
			{
				return sMatchup;
			}
		}

		public List<Step> Steps
		{
			get
			{
				return stepList;
			}
		}
	}
}
