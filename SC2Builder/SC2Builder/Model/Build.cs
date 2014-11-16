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
        private string sMatchup;
        private List<Step> steps;

        public Build(string name, string matchup, List<Step> steps)
        {
            this.sName = name;
            this.sMatchup = matchup;
            this.steps = new List<Step>(steps);
        }

        public override bool Equals(object obj)
        {
            if (obj is Build)
            {
                Build B = (Build) obj;
                return this.sName.Equals(B.sName);
            }
            return false;
        }

        public bool Equals(string str)
        {
            return this.sName.Equals(str);
        }

        public string Name
        {
            get
            {
                return sName;
            }
        }

        public string MatchUp
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
                return steps;
            }
        }

        public override string ToString()
        {
            string result = this.sName + "\n" + this.sMatchup + "\n";
            foreach (Step S in this.steps)
            {
                result += S.ToString() + "\n";
            }
            return result;
        }
    }
}
