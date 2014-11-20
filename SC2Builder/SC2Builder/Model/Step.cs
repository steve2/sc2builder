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

		public static List<string> GetTags(string full)
		{
			List<string> tagList = new List<string>();
			bool inTag = false;
			string tag = "";
			foreach (char c in full)
			{
				if (c == '{')
				{
					tag = "";
					inTag = true;
				}
				if (c == '}')
				{
					tagList.Add(tag.Substring(1));
					inTag = false;
				}
				if (inTag)
				{
					tag += c;
				}
			}
			return tagList;
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

		public string Requisite()
		{
			return sRequirement;
		}
		
		public string Command()
		{
			return sAction;
		}

		public string RawString()
		{
			return sRequirement + "-" + sAction;
		}

		public string ToNestedDisplayString()
		{
			return "     - " + ClearTags(this.sAction).Trim();
		}

		public string ToDisplayString()
		{
			return ClearTags(this.sRequirement).Trim() + " - " + ClearTags(this.sAction).Trim();
		}

	}
}
