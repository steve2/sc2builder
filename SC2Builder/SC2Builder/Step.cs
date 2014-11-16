using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC2Builder
{
    class Step
    {
        private int nSupply;
        private float fGameTime;
        private string sText;
        private string sWaitFor;

        public const int INVALID_SUPPLY = -1;
        public const float INVALID_TIME = -1f;

        public Step(int supply, float time, string text)
        {
            this.nSupply = supply;
            this.fGameTime = time;
            this.sText = text;
            this.sWaitFor = null;
        }

        public Step(int supply, string text)
        {
            this.nSupply = supply;
            this.fGameTime = INVALID_TIME;
            this.sText = text;
            this.sWaitFor = null;
        }

        public Step(string waitFor, string text)
        {
            this.nSupply = INVALID_SUPPLY;
            this.fGameTime = INVALID_TIME;
            this.sWaitFor = waitFor;
            this.sText = text;
        }

        public override string ToString()
        {
            string result = "";
            if (this.nSupply != INVALID_SUPPLY)
            {
                result += this.nSupply + " - " + this.sText;
            }
            else if (this.sWaitFor != null)
            {
                result += "100% " + this.sWaitFor + " - " + this.sText;
            }
            return result;
        }

    }
}
