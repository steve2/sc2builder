using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC2Builder.Logic
{
	class InitImageLookupTable
	{
		public static void Init(Dictionary<String, int> table)
		{
			table.Add("icon-protoss-small", 0);
			table.Add("icon-terran-small", 1);
			table.Add("icon-zerg-small", 2);

			table.Add("icon-zerg-gas", 3);
			table.Add("icon-zerg-supply", 4);
			table.Add("icon-zerg-time", 5);
			table.Add("icon-terran-gas", 6);
			table.Add("icon-terran-supply", 7);
			table.Add("icon-terran-time", 8);
			table.Add("icon-protoss-gas", 9);
			table.Add("icon-protoss-supply", 10);
			table.Add("icon-protoss-time", 11);
			table.Add("icon-minerals", 12);


		}
	}
}
