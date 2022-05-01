using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hei.Cnblog.Tools
{
    public class Appsettings
    {
        /// <summary>
        ///
        /// </summary>
        public Recentdir RecentDir { get; set; }
    }

    public class Recentdir
    {
        public int MaxRecond { get; set; }
        public List<string> Dirs { get; set; }
    }
}