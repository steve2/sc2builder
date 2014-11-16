using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC2Builder
{
    class Step
    {
        private string sRequirement;
        private string sAction;

        public const char TAG_OPEN = '{';
        public const char TAG_CLOSE = '}';

        public Step(string req, string act)
        {
            this.sRequirement = req;
            this.sAction = act;
        }

        public override string ToString()
        {
            return ClearTags(this.sRequirement) + "   - " + ClearTags(this.sAction);
        }

        public static string ClearTags(string orig)
        {
            string result = "";
            bool cpy = true;
            foreach (char c in orig)
            {
                if (c == '{') cpy = false;
                if (cpy) result += c;
                if (c == '}') cpy = true;
            }
            return result;
        }

    }
}
