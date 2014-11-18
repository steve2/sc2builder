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
			table.Add("icon-trashcan", 0);

			table.Add("icon-protoss-small", 1);
			table.Add("icon-terran-small", 2);
			table.Add("icon-zerg-small", 3);

			table.Add("icon-zerg-gas", 4);
			table.Add("icon-zerg-supply", 5);
			table.Add("icon-zerg-time", 6);
			table.Add("icon-terran-gas", 7);
			table.Add("icon-terran-supply", 8);
			table.Add("icon-terran-time", 9);
			table.Add("icon-protoss-gas", 10);
			table.Add("icon-protoss-supply", 11);
			table.Add("icon-protoss-time", 12);
			table.Add("icon-minerals", 13);
		}
	}
}
