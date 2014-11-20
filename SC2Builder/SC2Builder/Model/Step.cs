using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC2Builder
{
	class Step
	{
		public static Step ErrorStep = new Step("9999INVALID", "9999INVALID");

		private string sRequirement;
		private string sAction;

		public const char TAG_OPEN = '{';
		public const char TAG_CLOSE = '}';

		public Step(string req, string act)
		{
			this.sRequirement = req;
			this.sAction = act;
		}

		public string RawString()
		{
			return sRequirement + "-" + sAction;
		}

		public override string ToString()
		{
			return ClearTags(this.sRequirement).Trim() + "   - " + ClearTags(this.sAction).Trim();
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
