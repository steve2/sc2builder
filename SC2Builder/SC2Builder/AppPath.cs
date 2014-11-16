using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SC2Builder
{
    class AppPath
    {
        public static string GetRoot()
        {
            return Path.GetFullPath(Path.Combine(Application.StartupPath, "..", ".."));
        }

        public static string GetBuilds()
        {
            return Path.Combine(GetRoot(), "builds");
        }

        public static string GetResources()
        {
            return Path.Combine(GetRoot(), "Resources");
        }
    }
}
