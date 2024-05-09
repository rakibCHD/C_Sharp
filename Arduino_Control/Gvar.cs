using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arduino_Control
{
    class Gvar
    {
        public static bool isDhexUploaded = false;
        public static bool isNewHexUpload = false;
        public static int count=0;
        public static string AvrdudeExePath;
        public static string AvrConfigPath;
    }
}
