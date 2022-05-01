using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hei.Cnblog.Tools
{
    public class Const
    {
        public static string CnblogSettingPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.cnblog.json");

        public static string Appsettings = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

        public static byte[] TeaKey = new byte[] { 21, 52, 33, 78, 52, 45 };
    }
}