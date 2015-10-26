using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuix.Response
{
    class Export
    {
        public string functionKey { get; set; }
        public string location { get; set; }

        public string ToString()
        {
            return "[functionKey=" + functionKey + ",location=" + location + "]";
        }
    }
}
